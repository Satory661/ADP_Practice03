namespace ADP_Practice03;

public class PayPal : IPayment
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Payment for {amount} from paypal");
    }
}