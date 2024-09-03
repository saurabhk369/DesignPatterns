using RTSNotifications.NotificationStrategies;

namespace RTSNotifications;

public class NotificationService
{
    public readonly List<string> Notifications = [];
    private readonly List<IObserver> observers = [];

    public void Attach(IObserver observer)
        => observers.Add(observer);

    public void Notify(string message)
    {
        foreach (var observer in observers)
        {
            Notifications.Add(observer.Update(message));
        }
    }
}
