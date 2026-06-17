namespace BondCalc.App.Domain.Entities
{
    public class Deal
    {
        public double Price { get; init;  }
        public double ACI { get; init; }
        public DateOnly Date { get; init; }
        public Deal(double price, double aci, DateOnly date)
        {
            Price = price;
            ACI = aci;
            Date = date;
        }
    }
}
