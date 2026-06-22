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

        public List<ChartPoint> NominalYieldSeries { get; }
        public List<ChartPoint> RealYieldSeries { get; }
        public List<ChartPoint> InflationSeries { get; }
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

            NominalYieldSeries = CalculateNominalYieldSeries();
            RealYieldSeries = CalculateRealYieldSeries();
            InflationSeries = CalculateInflationSeries();
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
        public List<ChartPoint> CalculateNominalYieldSeries()
        {
            var points = new List<ChartPoint> { new(_deal.Date, 0) };
            foreach (var row in Schedule)
            {
                points.Add(new(row.Date, row.CumulativeIncome / BuyPrice * 100));
            }
            return points;
        }
        public List<ChartPoint> CalculateRealYieldSeries()
        {
            var points = new List<ChartPoint> { new(_deal.Date, 0) };
            foreach (var row in Schedule)
            {
                points.Add(new(row.Date, row.CumulativeRealIncome / BuyPrice * 100));
            }
            return points;
        }
        public List<ChartPoint> CalculateInflationSeries()
        {
            var points = new List<ChartPoint> { new(_deal.Date, 0) };
            foreach (var row in Schedule)
            {
                int days = row.Date.DayNumber - _deal.Date.DayNumber;
                double value = (Math.Pow(_dailyInflation, days) - 1) * 100;
                points.Add(new(row.Date, value));
            }
            return points;
        }
    }
}
