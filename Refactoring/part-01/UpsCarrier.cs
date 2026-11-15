namespace RefactoringLab;

public class UpsCarrier : IShippingCarrier
{
    public decimal CalculateCost(decimal weightKg) => 
        weightKg * 14;
}