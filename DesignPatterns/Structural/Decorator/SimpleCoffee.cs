namespace DesignPatterns.Structural.Decorator;

/// <summary>
/// Decorator pattern lets you dynamically change the behavior of an object at run time by wrapping them in an object of a decorator class.
/// </summary>
public class SimpleCoffee : ICoffee
{
    public int GetCost() => 3;

    public string GetDescription() => $"{GetType().Name} with: ";
}
