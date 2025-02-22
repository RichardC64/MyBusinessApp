using System.Diagnostics;
using BenchmarkDotNet.Attributes;

namespace StopBenchmarks;

public class UsingDebug
{
    private readonly List<decimal> _priceCollection = [19.99m, 34.55m];

    [Benchmark]
    public void RunIEnumerable()
    {
        IEnumerable<decimal> priceCollection = _priceCollection;
        foreach (var price in priceCollection)
        {
            Debug.WriteLine(price);
        }
    }
    [Benchmark]
    public void RunIEnumerator()
    {
        IEnumerator<decimal> priceEnumerator = _priceCollection.GetEnumerator();
        while (priceEnumerator.MoveNext())
            Debug.WriteLine(priceEnumerator.Current);
    }
}