namespace RTSNotifications.NotificationStrategies;

public class SMSObserver : IObserver
{
    public string Update(string message)
    {
        Console.WriteLine("SMS Notification Received.");
        return $"SMS: {message}";
    }
}
