namespace DesignPatterns.Behavioral.Strategy;

public interface ISortStrategy
{
    IEnumerable<int> Sort(IEnumerable<int> dataset);
}
