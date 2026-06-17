namespace BondCalc.App.Domain.Entities
{
    public class Bond
    {
        public double NominalValue { get; init; }
        public DateOnly DateOfPlacement { get; init; }
        public DateOnly DateOfRepayment { get; init; }
        public int CouponPeriodDays { get; init; }
        public List<Coupon> Coupons { get; init; }
        public List<Amortization> Amortizations { get; init;  }
    }
}
