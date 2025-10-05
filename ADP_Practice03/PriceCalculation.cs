namespace ADP_Practice03;
public class PriceCalculation
{
    public double Calculate(List<Product> products)
    {
        return products.Sum(p => p.Price);
    }
}