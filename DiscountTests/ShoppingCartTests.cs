using Discounts;
using Discounts.DiscountStrategies;

namespace DiscountTests;

[TestFixture]
public class ShoppingCartTests
{
    private Product beans;
    private Product rice;

    [OneTimeSetUp]
    public void Init()
    {
        beans = new ("Beans", 2);
        rice = new ("Rice", 1);
    }

    [Test]
    public void NoDiscount_ShouldReturnTotalValue()
    {
        ShoppingCart cart = new(new NoDiscount());
        cart.AddItem(new(beans, 2));

        double result = cart.GetTotalCartValue();
        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void BOGODiscountForEventItems_ShouldReturnHalfPrice()
    {
        ShoppingCart cart = new(new BuyOneGetOneDiscount());
        cart.AddItem(new(beans, 2));

        double result = cart.GetTotalCartValue();
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void BOGODiscountForOddtItems_ShouldReturnHalfPlusOnePrice()
    {
        ShoppingCart cart = new(new BuyOneGetOneDiscount());
        cart.AddItem(new(beans, 3));

        double result = cart.GetTotalCartValue();
        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void PercentDiscountOf25_ShouldReturn75PercentOfPrice()
    {
        ShoppingCart cart = new(new PercentDiscount(25));
        cart.AddItem(new(beans, 4));

        double result = cart.GetTotalCartValue();
        Assert.That(result, Is.EqualTo(6));
    }

    [Test]
    public void MultipleProductsWithDifferentDiscounts_ShouldReturnCorrentValue()
    {
        ShoppingCart cart = new();
        cart.AddItem(new (beans, 2), new BuyOneGetOneDiscount());
        cart.AddItem(new (rice, 4), new PercentDiscount(25));

        double result = cart.GetTotalCartValue();
        Assert.That(result, Is.EqualTo(5));
    }
}