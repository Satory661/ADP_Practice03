namespace ADP_Practice03;

public class PostDelivery : IDelivery
{
    public void ProcessDelivery(Order order)
    {
        Console.WriteLine($"Delivery for {order} from post");
    }
}