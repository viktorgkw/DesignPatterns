namespace DesignPatterns.Creational.FactoryMethod;

public class RecruiterManager : HiringManager
{
    protected override IInterviewer MakeInterviewer() => new HR();
}
