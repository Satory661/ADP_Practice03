namespace ADP_Practice03;

public class EmailNotification:  INotification
{
    public void SendNotification(string message)
    {
        Console.WriteLine(message);
    }
}