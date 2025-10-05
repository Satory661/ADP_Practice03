namespace ADP_Practice03;
public class DeliveryPoint : IDelivery
{
    public void ProcessDelivery(Order order)
    {
        Console.WriteLine($"Delivery for {order} from pickup");
    }
        
}