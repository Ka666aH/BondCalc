using BondCalc.App.Domain.Entities;

namespace BondCalc.App.Application.Factories
{
    public static class CouponFactory
    {
        public static Coupon Create(double amount, DateOnly date) => new(amount, date);
        public static List<Coupon> CreateList(double amount, DateOnly first, DateOnly last, int period)
        {
            List<Coupon> coupons = [];
            var date = first;
            while (date <= last)
            {
                coupons.Add(Create(amount, date));
                date = date.AddDays(period);
            }
            return coupons;
        }
    }
}
