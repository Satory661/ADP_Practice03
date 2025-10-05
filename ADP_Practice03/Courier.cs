namespace ADP_Practice03;
public class Courier : IDelivery
{
    public void ProcessDelivery(Order order)
    {
        Console.WriteLine($"Delivery for {order} from courier");
    }
}