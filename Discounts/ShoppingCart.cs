namespace Discounts;

public class ShoppingCart
{
    private readonly IDiscount DefaultDiscountStrategy;
    private List<CartItem> Items { get; set; } = [];
    private readonly Dictionary<CartItem, IDiscount> ItemDiscounts = [];

    public ShoppingCart()
    {
        DefaultDiscountStrategy = new NoDiscount();
    }

    public ShoppingCart(IDiscount discountStrategy)
    {
        DefaultDiscountStrategy = discountStrategy;
    }

    public void AddItem(CartItem item)
    {
        Items.Add(item);
        if (!ItemDiscounts.TryGetValue(item, out _))
            ItemDiscounts.Add(item, DefaultDiscountStrategy);
    }

    public void AddItem(CartItem item, IDiscount discount)
    {
        AddItem(item);
        ItemDiscounts[item] = discount;
    }

    public double GetTotalCartValue()
    {
        double total = 0;
        foreach (var item in Items)
        {
            total += ItemDiscounts[item].CalculateDiscount(item);
        }
        return total;
    }
}
