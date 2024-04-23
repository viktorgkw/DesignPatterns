namespace DesignPatterns.Behavioral.Command;

public class TurnOn(Bulb bulb) : ICommand
{
    private readonly Bulb _bulb = bulb
        ?? throw new ArgumentNullException(nameof(bulb), "Bulb cannot be null");

    public void Execute()
    {
        _bulb.TurnOn();
    }

    public void Undo()
    {
        _bulb.TurnOff();
    }

    public void Redo()
    {
        Execute();
    }
}
