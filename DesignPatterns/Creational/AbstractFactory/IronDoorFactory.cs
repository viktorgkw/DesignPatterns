namespace DesignPatterns.Creational.AbstractFactory;

public class IronDoorFactory : IDoorFactory
{
    public IDoorMaker GetDoorMaker() => new Welder();

    public IDoor MakeDoor() => new IronDoor();
}
