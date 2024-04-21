namespace DesignPatterns.Creational.AbstractFactory;

public interface IDoorFactory
{
    IDoor MakeDoor();

    IDoorMaker GetDoorMaker();
}
