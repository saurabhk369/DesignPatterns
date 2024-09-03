namespace Discounts.DiscountStrategies;

public class PercentDiscount(double percentDiscount) : IDiscount
{
    public double CalculateDiscount(CartItem item)
    {
        double discount = item.GetTotalValue() * percentDiscount / 100;
        return item.GetTotalValue() - discount;
    }
}
