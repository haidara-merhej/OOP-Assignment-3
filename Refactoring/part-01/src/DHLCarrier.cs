namespace RefactoringLab;

public class DHLCarrier : IShippingCarrier
{
    public decimal CalculateCost(decimal weightKg)
     => weightKg * 18m;
}