namespace DesignPatterns.Creational.Builder;

/// <summary>
/// When there could be several flavors of an object and to avoid the constructor telescoping. The key difference from the factory pattern is that; factory pattern is to be used when the creation is a one step process while builder pattern is to be used when the creation is a multi step process.
/// </summary>
public class BurgerBuilder(int size)
{
    public int Size = size;
    public bool Cheese;
    public bool Pepperoni;
    public bool Lettuce;
    public bool Tomato;

    public Burger Build() => new Burger(this);

    public BurgerBuilder AddCheese()
    {
        Cheese = true;
        return this;
    }

    public BurgerBuilder AddPepperoni()
    {
        Pepperoni = true;
        return this;
    }

    public BurgerBuilder AddLettuce()
    {
        Lettuce = true;
        return this;
    }

    public BurgerBuilder AddTomato()
    {
        Tomato = true;
        return this;
    }
}
