namespace RefactoringLab;

public class FedExCarrier : IShippingCarrier
{
    public decimal CalculateCost(decimal weightKg)
     => weightKg * 15m;
}
