namespace DesignPatterns.Creational.FactoryMethod;

public class DevelopmentManager : HiringManager
{
    protected override IInterviewer MakeInterviewer() => new Developer();
}
