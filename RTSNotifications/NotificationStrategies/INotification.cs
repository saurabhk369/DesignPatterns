namespace RTSNotifications.NotificationStrategies;

public interface IObserver
{
    string Update(string message);
}
