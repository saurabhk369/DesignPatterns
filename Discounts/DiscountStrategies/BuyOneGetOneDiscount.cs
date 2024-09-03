namespace Discounts.DiscountStrategies;

public class BuyOneGetOneDiscount : IDiscount
{
    public double CalculateDiscount(CartItem item)          // qty: 3           qty: 2
    {
        int freeQty = item.Quantity / 2;                    // qty: 3/2 = 1     qty: 2/2 = 1
        int paidQty = item.Quantity - freeQty;              // qty: 3-2 = 1     qty: 2-1 = 1
        return paidQty * item.Product.Price;                // (1+1) * x        qty: (1+1) * x
    }
}
