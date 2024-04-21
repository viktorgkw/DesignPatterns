namespace DesignPatterns.Creational.Prototype;

public class Dummy(string name)
{
    public string Name { get; set; } = name;

    public Dummy Clone() => MemberwiseClone() as Dummy;
}
