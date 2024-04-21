namespace DesignPatterns.Creational.AbstractFactory;

public class WoodenDoorFactory : IDoorFactory
{
    public IDoorMaker GetDoorMaker() => new Carpenter();

    public IDoor MakeDoor() => new WoodenDoor();
}
