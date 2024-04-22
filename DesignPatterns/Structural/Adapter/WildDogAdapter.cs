namespace DesignPatterns.Structural.Adapter;

/// <summary>
/// Adapter pattern lets you wrap an otherwise incompatible object in an adapter to make it compatible with another class.
/// </summary>
public class WildDogAdapter(WildDog dog) : ILion
{
    private readonly WildDog _dog = dog;

    public void Roar() => _dog.Bark();
}
