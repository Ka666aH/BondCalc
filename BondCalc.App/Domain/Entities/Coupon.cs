namespace BondCalc.App.Domain.Entities
{
    public class Coupon
    {
        public double Amount { get; init; }
        public DateOnly Date { get; init; }
        public Coupon(double amount, DateOnly date)
        {
            Amount = amount;
            Date = date;
        }
    }
}
