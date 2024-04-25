namespace DesignPatterns.Behavioral.State;

public class DefaultText : IWritingState
{
    public void Write(string words) => Console.WriteLine(words);
}
