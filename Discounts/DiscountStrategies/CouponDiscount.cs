namespace Discounts.DiscountStrategies;

public class CouponDiscount(string couponCode) : IDiscount
{
    private Dictionary<string, int> couponCodesDiscountPercents = new() { { "Percent25", 25 }, { "Percent50", 50 } };
    public double CalculateDiscount(CartItem item)
    {
        if (couponCodesDiscountPercents.TryGetValue(couponCode, out var percent))
        {
            IDiscount percentDiscount = new PercentDiscount(percent);
            double discountedPrice = percentDiscount.CalculateDiscount(item);
            return discountedPrice;
        }
        return item.GetTotalValue();
    }
}
