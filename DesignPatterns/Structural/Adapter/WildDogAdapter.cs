namespace DesignPatterns.Structural.Adapter;

public class WildDogAdapter(WildDog dog) : ILion
{
    private readonly WildDog _dog = dog;

    public void Roar() => _dog.Bark();
}
