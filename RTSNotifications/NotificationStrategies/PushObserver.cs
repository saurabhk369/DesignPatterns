namespace RTSNotifications.NotificationStrategies;

public class PushObserver : IObserver
{
    public string Update(string message)
    {
        Console.WriteLine("Push Notification Received.");
        return $"Push: {message}";
    }
}
