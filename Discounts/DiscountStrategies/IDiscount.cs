namespace Discounts;

public interface IDiscount
{
    double CalculateDiscount(CartItem item);
}
