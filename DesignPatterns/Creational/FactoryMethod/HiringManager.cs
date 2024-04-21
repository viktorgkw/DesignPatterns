namespace DesignPatterns.Creational.FactoryMethod;

/// <summary>
/// Useful when there is some generic processing in a class but the required sub-class is dynamically decided at runtime. Or putting it in other words, when the client doesn't know what exact sub-class it might need.
/// </summary>
public abstract class HiringManager
{
    abstract protected IInterviewer MakeInterviewer();

    public void TakeInterview()
    {
        var interviewer = MakeInterviewer();
        interviewer.AskQuestions();
    }
}
