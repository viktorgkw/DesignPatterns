namespace DesignPatterns.Structural.Flyweight;

/// <summary>
/// It is used to minimize memory usage or computational expenses by sharing as much as possible with similar objects.
/// </summary>
public class TeaShop(TeaMaker teaMaker)
{
    private readonly Dictionary<int, KarakTea> _orders = [];
    private readonly TeaMaker mTeaMaker = teaMaker
        ?? throw new ArgumentNullException(nameof(teaMaker), "TeaMaker cannot be null!");

    public void TakeOrder(string teaType, int table)
    {
        _orders[table] = mTeaMaker.Make(teaType);
    }

    public void Serve()
    {
        foreach (var table in _orders.Keys)
        {
            Console.WriteLine($"Serving Tea to table #{table}...");
        }
    }
}
