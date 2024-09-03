namespace RTSNotifications.NotificationStrategies;

public class EmailObserver : IObserver
{
    public string Update(string message)
    {
        Console.WriteLine("Email Notification Received.");
        return $"Email: {message}";
    }
}
