namespace DesignPatterns.Behavioral.Strategy;

public class BubbleSortStrategy : ISortStrategy
{
    public IEnumerable<int> Sort(IEnumerable<int> dataset)
    {
        Console.WriteLine("-> Bubble Sort");
        return dataset;
    }
}
