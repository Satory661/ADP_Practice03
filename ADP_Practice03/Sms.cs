namespace ADP_Practice03;

public class SmsNotification: INotification
{
    public void SendNotification(string message)
    {
        Console.WriteLine(message);
    }
}