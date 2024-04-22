namespace DesignPatterns.Structural.Decorator;

public class MilkCoffee(ICoffee coffee) : ICoffee
{
    private readonly ICoffee _coffee = coffee
        ?? throw new ArgumentNullException(nameof(coffee), "Coffee should not be null!");

    public int GetCost() => _coffee.GetCost() + 2;

    public string GetDescription() => $"{_coffee.GetDescription()} milk,";
}
