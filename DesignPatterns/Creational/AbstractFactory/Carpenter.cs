namespace DesignPatterns.Creational.AbstractFactory;

public class Carpenter : IDoorMaker
{
    public string MakeType() => "I make wooden doors.";
}
