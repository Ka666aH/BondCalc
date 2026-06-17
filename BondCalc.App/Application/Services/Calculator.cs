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
        public double RealTotalIncome { get; }
        public double TotalYield { get; }
        public double RealTotalYield { get; }
        public double AnnualYield { get; }
        public double RealAnnualYield { get; }
        public Calculator(Bond bond, Deal deal, double annualInflation)
        {
            _bond = bond;
            _deal = deal;
            _dailyInflation = annualInflation / _daysInYear;
            _daysToRepayment = _bond.Repayment.DayNumber - _deal.Date.DayNumber;

            BuyPrice = CalculateBuyPrice();
            RepaymentIncome = CalculateRepaymentIncome();
            TotalCouponIncome = CalculateTotalCouponIncome();
            TotalIncome = CalculateTotalIncome();
            RealTotalIncome = CalculateRealTotalIncome();
            TotalYield = CalculateTotalYield();
            RealTotalYield = CalculateRealTotalYield();
            AnnualYield = CalculateAnnualYield();
            RealAnnualYield = CalculateRealAnnualYield();
        }
        private double CalculateBuyPrice() => _deal.Price + _deal.ACI;
        private double CalculateRepaymentIncome() => _bond.Value - _deal.Price;
        private double CalculateTotalCouponIncome() => _bond.Coupons.Sum(x => x.Amount);
        private double CalculateTotalIncome() => RepaymentIncome + TotalCouponIncome;
        private double CalculateRealTotalIncome()
        {
            double result = 0;
            foreach (var coupon in _bond.Coupons)
            {
                int days = coupon.Date.DayNumber - _deal.Date.DayNumber;
                double totalInflation = Math.Pow(1 + _dailyInflation, days);
                double realCouponAmount = coupon.Amount / totalInflation;
                result += realCouponAmount;
            }
            double amortizationSum = 0;
            foreach (var amortization in _bond.Amortizations)
            {
                amortizationSum += amortization.Amount;
                int days = amortization.Date.DayNumber - _deal.Date.DayNumber;
                double totalInflation = Math.Pow(1 + _dailyInflation, days);
                double realAmortizationIncome = amortization.Amount / totalInflation;
                result += realAmortizationIncome;
            }
            if (amortizationSum < _bond.Value)
            {
                double totalInflation = Math.Pow(1 + _dailyInflation, _daysToRepayment);
                double realRepaymentIncome = (_bond.Value - amortizationSum) / totalInflation;
                result += realRepaymentIncome;
            }

            return result;
        }
        private double CalculateTotalYield() => TotalIncome / BuyPrice;
        private double CalculateRealTotalYield() => RealTotalIncome / BuyPrice;
        private double CalculateAnnualYield() => TotalYield / _daysToRepayment * _daysInYear;
        private double CalculateRealAnnualYield() => RealTotalYield / _daysToRepayment * _daysInYear;
    }
}
