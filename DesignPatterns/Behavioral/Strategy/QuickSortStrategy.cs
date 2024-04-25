namespace DesignPatterns.Behavioral.Strategy;

public class QuickSortStrategy : ISortStrategy
{
    public IEnumerable<int> Sort(IEnumerable<int> dataset)
    {
        Console.WriteLine("-> Quick Sort");
        return dataset;
    }
}
