namespace DesignPatterns.Creational.Builder;

public class Burger(BurgerBuilder builder)
{
    private readonly int _size = builder.Size;
    private readonly bool _cheese = builder.Cheese;
    private readonly bool _pepperoni = builder.Pepperoni;
    private readonly bool _lettuce = builder.Lettuce;
    private readonly bool _tomato = builder.Tomato;

    public string GetDescription() => $"This is {_size} inch Burger.";

    public bool HasCheese() => _cheese;

    public bool HasPepperoni() => _pepperoni;

    public bool HasLettuce() => _lettuce;

    public bool HasTomato() => _tomato;
}
