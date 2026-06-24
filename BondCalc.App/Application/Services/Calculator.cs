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
            return result - _deal.Price;
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
            var rows = new List<ScheduleRow>();
            double cumulativeNominal = 0;
            double cumulativeReal = 0;

            foreach (var coupon in _bond.Coupons)
            {
                int days = coupon.Date.DayNumber - _deal.Date.DayNumber;
                double infl = Math.Pow(_dailyInflation, days);
                double real = coupon.Amount / infl;
                cumulativeNominal += coupon.Amount;
                cumulativeReal += real;
                rows.Add(new(coupon.Date, "Coupon", coupon.Amount, cumulativeNominal, real, cumulativeReal));
            }

            double amortSum = 0;
            foreach (var amort in _bond.Amortizations)
            {
                amortSum += amort.Amount;
                int days = amort.Date.DayNumber - _deal.Date.DayNumber;
                double infl = Math.Pow(_dailyInflation, days);
                double real = amort.Amount / infl;
                cumulativeNominal += amort.Amount;
                cumulativeReal += real;
                rows.Add(new(amort.Date, "Amortization", amort.Amount, cumulativeNominal, real, cumulativeReal));
            }

            double remaining = _bond.Value - amortSum;
            if (remaining > 0)
            {
                double infl = Math.Pow(_dailyInflation, _daysToRepayment);
                double real = remaining / infl;
                cumulativeNominal += remaining;
                cumulativeReal += real;
                rows.Add(new(_bond.Repayment, "Repayment", remaining, cumulativeNominal, real, cumulativeReal));
            }

            return [.. rows.OrderBy(r => r.Date)];
        }
        private (List<ChartPoint>, List<ChartPoint>, List<ChartPoint>) CalculateChartSeries()
        {
            int capacity = _daysToRepayment + 1;
            var nominalPoints = new List<ChartPoint>(capacity) { new(_deal.Date, 0) };
            var realPoints = new List<ChartPoint>(capacity) { new(_deal.Date, 0) };
            var inflPoints = new List<ChartPoint>(capacity) { new(_deal.Date, 0) };

            double cashNominal = 0;
            double cashReal = 0;
            double amortSum = 0;
            int couponIdx = 0;
            int amortIdx = 0;

            double totalAmort = _bond.Amortizations.Sum(a => a.Amount);
            double finalRemaining = _bond.Value - totalAmort;

            for (int offset = 1; offset <= _daysToRepayment; offset++)
            {
                var date = _deal.Date.AddDays(offset);
                int todayDays = date.DayNumber - _deal.Date.DayNumber;

                while (couponIdx < _bond.Coupons.Count
                    && _bond.Coupons[couponIdx].Date == date)
                {
                    var c = _bond.Coupons[couponIdx];
                    int d = c.Date.DayNumber - _deal.Date.DayNumber;
                    double infl = Math.Pow(_dailyInflation, d);
                    cashNominal += c.Amount;
                    cashReal += c.Amount / infl;
                    couponIdx++;
                }

                while (amortIdx < _bond.Amortizations.Count
                    && _bond.Amortizations[amortIdx].Date == date)
                {
                    var a = _bond.Amortizations[amortIdx];
                    int d = a.Date.DayNumber - _deal.Date.DayNumber;
                    double infl = Math.Pow(_dailyInflation, d);
                    cashNominal += a.Amount;
                    cashReal += a.Amount / infl;
                    amortSum += a.Amount;
                    amortIdx++;
                }

                double t = (double)offset / _daysToRepayment;
                double currentCleanPrice = _deal.Price
                    + (finalRemaining - _deal.Price) * t;

                double inflForDay = Math.Pow(_dailyInflation, todayDays);

                double nominalWealth = cashNominal + currentCleanPrice;
                double realWealth = cashReal + currentCleanPrice / inflForDay;

                if (couponIdx < _bond.Coupons.Count)
                {
                    var nextCoupon = _bond.Coupons[couponIdx];
                    DateOnly prevDate = couponIdx > 0
                        ? _bond.Coupons[couponIdx - 1].Date
                        : _bond.Placement;
                    int period = nextCoupon.Date.DayNumber - prevDate.DayNumber;
                    int sincePrev = date.DayNumber - prevDate.DayNumber;
                    if (period > 0 && sincePrev > 0)
                    {
                        double frac = (double)sincePrev / period;
                        double accrued = nextCoupon.Amount * frac;
                        nominalWealth += accrued;
                        int d = nextCoupon.Date.DayNumber - _deal.Date.DayNumber;
                        realWealth += accrued / Math.Pow(_dailyInflation, d);
                    }
                }

                nominalPoints.Add(new(date,
                    (nominalWealth - BuyPrice) / BuyPrice * 100));
                realPoints.Add(new(date,
                    (realWealth - BuyPrice) / BuyPrice * 100));
                inflPoints.Add(new(date, (inflForDay - 1) * 100));
            }

            return (nominalPoints, realPoints, inflPoints);
        }
    }
}
