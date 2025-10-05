namespace ADP_Practice03;

public class CreditCard : IPayment
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Payment for {amount} from creditcard");
    }
}