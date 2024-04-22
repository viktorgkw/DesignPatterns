namespace DesignPatterns.Structural.Decorator;

public class WhipCoffee(ICoffee coffee) : ICoffee
{
    private readonly ICoffee _coffee = coffee ?? throw new ArgumentNullException("coffee", "Coffee should not be null!");

    public int GetCost() => _coffee.GetCost() + 1;

    public string GetDescription() => $"{_coffee.GetDescription()} whip,";
}
