using BondCalc.App.Domain.Entities;

namespace BondCalc.App.Application.Factories
{
    public static class AmortizationFactory
    {
        public static Amortization Create(double amount, DateOnly date) => new(amount, date);
    }
}
