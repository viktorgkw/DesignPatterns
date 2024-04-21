namespace DesignPatterns.Creational.FactoryMethod;

public class Developer : IInterviewer
{
    public void AskQuestions() => Console.WriteLine("What can you tell me about design patterns?");
}
