namespace DesignPatterns.Creational.FactoryMethod;

public class HR : IInterviewer
{
    public void AskQuestions() => Console.WriteLine("What is your English level?");
}
