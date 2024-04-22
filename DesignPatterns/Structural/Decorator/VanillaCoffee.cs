namespace DesignPatterns.Structural.Decorator;

public class VanillaCoffee(ICoffee coffee) : ICoffee
{
    private readonly ICoffee _coffee = coffee
        ?? throw new ArgumentNullException(nameof(coffee), "Coffee should not be null!");

    public int GetCost() => _coffee.GetCost() + 3;

    public string GetDescription() => $"{_coffee.GetDescription()} vanilla,";
}
