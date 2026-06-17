using BondCalc.App.Domain.Entities;

namespace BondCalc.App.Application.Factories
{
    public static class DealFactory
    {
        public static Deal Create(double price, double aci, DateOnly date) => new(price, aci, date);
    }
}
