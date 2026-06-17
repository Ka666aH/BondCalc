namespace BondCalc.App.Domain.Entities
{
    public class Bond
    {
        public double Value { get; init; }
        public DateOnly Placement { get; init; }
        public DateOnly Repayment { get; init; }
        public List<Coupon> Coupons { get; init; }
        public List<Amortization> Amortizations { get; init;  }
        public Bond(double value, DateOnly placement, DateOnly repayment, List<Coupon> coupons, List<Amortization> amortizations)
        {
            Value = value;
            Placement = placement;
            Repayment = repayment;
            Coupons = coupons;
            Amortizations = amortizations;
        }
        
    }
}
