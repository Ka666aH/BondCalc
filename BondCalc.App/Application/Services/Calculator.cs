using BondCalc.App.Domain.Entities;

namespace BondCalc.App.Application.Services
{
    public class Calculator
    {
        private Bond _bond;
        private Deal _deal;
        private double _dailyInflation;
        private int _daysToRepayment;

        private const double _daysInYear = 365.25;

        public double BuyPrice { get; }

        public double RepaymentIncome { get; }
        public double TotalCouponIncome { get; }
        public double TotalIncome { get; }
        public double TotalYield { get; }
        public double AnnualYield { get; }

        public double RealRepaymentIncome { get; }
        public double RealTotalCouponIncome { get; }
        public double RealTotalIncome { get; }
        public double RealTotalYield { get; }
        public double RealAnnualYield { get; }

        public List<ScheduleRow> Schedule { get; }

        public List<ChartPoint> NominalYieldSeries { get; private set; }
        public List<ChartPoint> RealYieldSeries { get; private set; }
        public List<ChartPoint> InflationSeries { get; private set; }
        public Calculator(Bond bond, Deal deal, double annualInflationRate)
        {
            _bond = bond;
            _deal = deal;
            _dailyInflation = 1 + (annualInflationRate / _daysInYear);
            _daysToRepayment = _bond.Repayment.DayNumber - _deal.Date.DayNumber;

            if (_daysToRepayment <= 0)
            {
                throw new InvalidOperationException(
                    Localization.GetString("MsgDaysToRepaymentZero"));
            }

            if (_dailyInflation <= 0)
            {
                throw new InvalidOperationException(
                    Localization.GetString("MsgInflationOutOfRange"));
            }

            BuyPrice = CalculateBuyPrice();

            RepaymentIncome = CalculateRepaymentIncome();
            TotalCouponIncome = CalculateTotalCouponIncome();
            TotalIncome = CalculateTotalIncome();
            TotalYield = CalculateTotalYield();
            AnnualYield = CalculateAnnualYield();

            RealRepaymentIncome = CalculateRealRepaymentIncome();
            RealTotalCouponIncome = CalculateRealTotalCouponIncome();
            RealTotalIncome = CalculateRealTotalIncome();
            RealTotalYield = CalculateRealTotalYield();
            RealAnnualYield = CalculateRealAnnualYield();

            Schedule = CalculateSchedule();

            (NominalYieldSeries, RealYieldSeries, InflationSeries) = CalculateChartSeries();
        }
        private double CalculateBuyPrice() => _deal.Price + _deal.ACI;
        private double CalculateRepaymentIncome() => _bond.Value - _deal.Price;
        private double CalculateTotalCouponIncome() => _bond.Coupons.Sum(x => x.Amount);
        private double CalculateTotalIncome() => RepaymentIncome + TotalCouponIncome;
        private double CalculateRealRepaymentIncome()
        {
            double result = 0;
            double amortizationSum = 0;
            foreach (var amortization in _bond.Amortizations)
            {
                amortizationSum += amortization.Amount;
                int days = amortization.Date.DayNumber - _deal.Date.DayNumber;
                double totalInflation = Math.Pow(_dailyInflation, days);
                double realAmortizationIncome = amortization.Amount / totalInflation;
                result += realAmortizationIncome;
            }
            if (amortizationSum < _bond.Value)
            {
                double totalInflation = Math.Pow(_dailyInflation, _daysToRepayment);
                double realRepaymentIncome = (_bond.Value - amortizationSum) / totalInflation;
                result += realRepaymentIncome;
            }
            return result - BuyPrice;
        }
        private double CalculateRealTotalCouponIncome()
        {
            double result = 0;
            foreach (var coupon in _bond.Coupons)
            {
                int days = coupon.Date.DayNumber - _deal.Date.DayNumber;
                double totalInflation = Math.Pow(_dailyInflation, days);
                double realCouponAmount = coupon.Amount / totalInflation;
                result += realCouponAmount;
            }
            return result;
        }
        private double CalculateRealTotalIncome() => RealRepaymentIncome + RealTotalCouponIncome;
        private double CalculateTotalYield() => TotalIncome / BuyPrice;
        private double CalculateRealTotalYield() => RealTotalIncome / BuyPrice;
        private double CalculateAnnualYield() => TotalYield / _daysToRepayment * _daysInYear;
        private double CalculateRealAnnualYield() => RealTotalYield / _daysToRepayment * _daysInYear;

        private List<ScheduleRow> CalculateSchedule()
        {
            var events = new List<(DateOnly Date, string Type, double Amount)>();

            foreach (var c in _bond.Coupons)
                events.Add((c.Date, "Coupon", c.Amount));
            foreach (var a in _bond.Amortizations)
                events.Add((a.Date, "Amortization", a.Amount));

            double totalAmort = _bond.Amortizations.Sum(a => a.Amount);
            double remaining = _bond.Value - totalAmort;
            if (remaining > 0)
                events.Add((_bond.Repayment, "Repayment", remaining));

            events.Sort((a, b) => a.Date.CompareTo(b.Date));

            var rows = new List<ScheduleRow>(events.Count);
            double cumulativeNominal = 0;
            double cumulativeReal = 0;

            foreach (var (date, type, amount) in events)
            {
                int days = date.DayNumber - _deal.Date.DayNumber;
                double infl = Math.Pow(_dailyInflation, days);
                double real = amount / infl;
                cumulativeNominal += amount;
                cumulativeReal += real;
                rows.Add(new(date, type, amount, cumulativeNominal, real, cumulativeReal));
            }

            return rows;
        }
        private (List<ChartPoint>, List<ChartPoint>, List<ChartPoint>) CalculateChartSeries()
        {
            var nominalPoints = new List<ChartPoint>(_daysToRepayment + 1);
            var realPoints = new List<ChartPoint>(_daysToRepayment + 1);
            var inflPoints = new List<ChartPoint>(_daysToRepayment + 1);

            double cashNominal = 0;
            double cashReal = 0;
            double amortSum = 0;

            double priceDiff = _deal.Price - _bond.Value;

            for (int offset = 0; offset <= _daysToRepayment; offset++)
            {
                var date = _deal.Date.AddDays(offset);
                double lifeProgress = (double)offset / _daysToRepayment;
                double inflFactor = Math.Pow(_dailyInflation, offset);

                foreach (var coupon in _bond.Coupons.Where(c => c.Date == date))
                {
                    cashNominal += coupon.Amount;
                    cashReal += coupon.Amount / inflFactor;
                }

                foreach (var amort in _bond.Amortizations.Where(a => a.Date == date))
                {
                    cashNominal += amort.Amount;
                    cashReal += amort.Amount / inflFactor;
                    amortSum += amort.Amount;
                }

                double remainingFace = _bond.Value - amortSum;
                double cleanPrice = remainingFace + priceDiff * (1 - lifeProgress);

                double accruedNominal = 0;
                var nextCoupon = _bond.Coupons.FirstOrDefault(c => c.Date >= date);
                if (nextCoupon != null && nextCoupon.Date > date)
                {
                    DateOnly prevDate = _deal.Date;
                    double baseAccrued = _deal.ACI;

                    var lastPaid = _bond.Coupons
                        .Where(c => c.Date < nextCoupon.Date && c.Date < date)
                        .OrderByDescending(c => c.Date)
                        .FirstOrDefault();
                    if (lastPaid != null)
                    {
                        prevDate = lastPaid.Date;
                        baseAccrued = 0;
                    }

                    int period = nextCoupon.Date.DayNumber - prevDate.DayNumber;
                    int sincePrev = date.DayNumber - prevDate.DayNumber;
                    if (period > 0 && sincePrev > 0)
                    {
                        accruedNominal = baseAccrued
                            + (nextCoupon.Amount - baseAccrued) * (double)sincePrev / period;
                    }
                    else if (sincePrev == 0)
                    {
                        accruedNominal = baseAccrued;
                    }
                }
                else if (nextCoupon != null && nextCoupon.Date == date)
                {
                    accruedNominal = 0;
                }

                double nominalWealth = cashNominal + cleanPrice + accruedNominal;
                double realWealth = cashReal + cleanPrice / inflFactor + accruedNominal / inflFactor;

                nominalPoints.Add(new(date,
                    (nominalWealth - BuyPrice) / BuyPrice * 100));
                realPoints.Add(new(date,
                    (realWealth - BuyPrice) / BuyPrice * 100));
                inflPoints.Add(new(date, (inflFactor - 1) * 100));
            }

            return (nominalPoints, realPoints, inflPoints);
        }
    }
}
