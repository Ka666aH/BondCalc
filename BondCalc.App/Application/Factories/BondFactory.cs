using BondCalc.App.Domain.Entities;

namespace BondCalc.App.Application.Factories
{
    public static class BondFactory
    {
        public static Bond Create(double value, DateOnly placement, DateOnly repayment, List<Coupon> coupons, List<Amortization> amortizations)
            => new(value, placement, repayment, coupons, amortizations);
    }
}
