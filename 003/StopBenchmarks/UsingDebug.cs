using System.Diagnostics;

internal class UsingDebug
{
    private List<decimal> _priceCollection = new List<decimal> { 19.99m, 34.55m };
    public void RunIEnumerable()
    {
        IEnumerable<decimal> priceCollection = _priceCollection;
        foreach (var price in priceCollection)
        {
            Debug.WriteLine(price);
        }
    }

    public void RunIEnumerator()
    {
        IEnumerator<decimal> priceEnumerator = _priceCollection.GetEnumerator();
        while (priceEnumerator.MoveNext())
            Debug.WriteLine(priceEnumerator.Current);
    }
}