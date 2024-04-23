namespace DesignPatterns.Behavioral.Command;

public class TurnOff(Bulb bulb) : ICommand
{
    private readonly Bulb _bulb = bulb
        ?? throw new ArgumentNullException("bulb", "Bulb cannot be null");

    public void Execute()
    {
        _bulb.TurnOff();
    }

    public void Undo()
    {
        _bulb.TurnOn();
    }

    public void Redo()
    {
        Execute();
    }
}
