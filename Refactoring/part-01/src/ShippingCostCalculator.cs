namespace RefactoringLab;

public class ShippingCostCalculator
{

    public decimal Calculate(IShippingCarrier shippingCarrier, decimal weightKg)
    {
        return shippingCarrier.CalculateCost(weightKg);
    }
}
