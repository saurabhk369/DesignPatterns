using RTSNotifications;
using RTSNotifications.NotificationStrategies;

namespace RTSNotificationsTests;

[TestFixture]
public class OrderTests
{
    string orderMessage = "";
    string sms = "";
    string email = "";
    string push = "";

    [SetUp]
    public void Setup()
    {
        orderMessage = "order placed successfully.";
        sms = $"SMS: {orderMessage}";
        email = $"Email: {orderMessage}";
        push = $"Push: {orderMessage}";
    }

    [Test]
    public void AddingSMSObserver_ShouldNotifyBySMS()
    {
        Orders orders = new();
        orders.AddObserver(new SMSObserver());
        IEnumerable<string> messages = orders.PlaceOrder(orderMessage);
        Assert.That(messages, Is.EquivalentTo(new List<string>() { sms }));
    }


    [Test]
    public void AddingEmailObserver_ShouldNotifyByEmail()
    {
        Orders orders = new();
        orders.AddObserver(new EmailObserver());
        IEnumerable<string> messages = orders.PlaceOrder(orderMessage);
        Assert.That(messages, Is.EquivalentTo(new List<string>() { email }));
    }


    [Test]
    public void AddingPushObserver_ShouldNotifyByPush()
    {
        Orders orders = new();
        orders.AddObserver(new PushObserver());
        IEnumerable<string> messages = orders.PlaceOrder(orderMessage);
        Assert.That(messages, Is.EquivalentTo(new List<string>() { push }));
    }


    [Test]
    public void AddingSMSAndEmailObserver_ShouldNotifyBySMSAndEmail()
    {
        Orders orders = new();
        orders.AddObserver(new SMSObserver());
        orders.AddObserver(new EmailObserver());
        IEnumerable<string> messages = orders.PlaceOrder(orderMessage);
        Assert.That(messages, Is.EquivalentTo(new List<string>() { sms, email }));
    }
}
