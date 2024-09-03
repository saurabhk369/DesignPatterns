using RTSNotifications.NotificationStrategies;

namespace RTSNotifications;

public class Orders
{
    readonly NotificationService notificationService;

    public Orders()
    {
        notificationService = new NotificationService();
    }

    public void AddObserver(IObserver observer)
    {
        notificationService.Attach(observer);
    }

    public IEnumerable<string> PlaceOrder(string message)
    {
        notificationService.Notify(message);
        return notificationService.Notifications;
    }
}
