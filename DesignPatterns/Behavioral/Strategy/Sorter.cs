namespace DesignPatterns.Behavioral.Strategy;

/// <summary>
/// Strategy pattern allows you to switch the algorithm or strategy based upon the situation.
/// </summary>
public class Sorter(ISortStrategy sorter)
{
    private readonly ISortStrategy _sorter = sorter;

    public IEnumerable<int> Sort(IEnumerable<int> unSortedList)
        => _sorter.Sort(unSortedList);
}
