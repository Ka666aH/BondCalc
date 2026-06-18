namespace BondCalc.App.Domain.Entities
{
    public record ScheduleRow(DateOnly Date, string Type, double NominalAmount, double CumulativeIncome, double RealAmount, double CumulativeRealIncome);
}
