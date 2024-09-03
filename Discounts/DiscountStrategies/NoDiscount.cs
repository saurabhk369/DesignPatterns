namespace Discounts;

public class NoDiscount : IDiscount
{
    public double CalculateDiscount(CartItem item)
    {
        return item.GetTotalValue();
    }
}
