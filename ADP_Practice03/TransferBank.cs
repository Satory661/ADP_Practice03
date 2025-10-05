namespace ADP_Practice03;

public class BankTransfer: IPayment
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Bank Transfer Payment {amount}");
    }
}