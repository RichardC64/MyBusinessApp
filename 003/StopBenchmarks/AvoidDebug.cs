namespace StopBenchmarks;

public class AvoidDebug
{
    private List<decimal> _priceCollection = new List<decimal> { 19.99m, 34.55m };

    public decimal RunIEnumerable()
    {
        IEnumerable<decimal> priceCollection = _priceCollection;
        var sum = 0m;
        foreach (var price in priceCollection)
            sum += price;

        return sum;
    }
    public decimal RunIEnumerator()
    {
        IEnumerator<decimal> priceEnumerator = _priceCollection.GetEnumerator();
        var sum = 0m;
        while (priceEnumerator.MoveNext())

            sum += priceEnumerator.Current;

        return sum;
    }
}