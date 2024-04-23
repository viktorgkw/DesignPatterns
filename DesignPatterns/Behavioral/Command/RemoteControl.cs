namespace DesignPatterns.Behavioral.Command;

/// <summary>
/// Allows you to encapsulate actions in objects. The key idea behind this pattern is to provide the means to decouple client from receiver.
/// </summary>
public class RemoteControl
{
    public void Submit(ICommand command) => command.Execute();
}
