namespace BondCalc.App.Domain.Entities
{
    public class Amortization
    {
        public double Amount { get; init; }
        public DateOnly Date { get; init; }
        public Amortization(double amount, DateOnly date)
        {
            Amount = amount;
            Date = date;
        }
    }
}
