namespace RefactoringLab;

public class AramexCarrier : IShippingCarrier
{
    public decimal CalculateCost(decimal weightKg)
     => weightKg * 12m;
}
