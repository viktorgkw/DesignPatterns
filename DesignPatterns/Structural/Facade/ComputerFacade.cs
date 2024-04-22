namespace DesignPatterns.Structural.Facade;

/// <summary>
/// Facade pattern provides a simplified interface to a complex subsystem.
/// </summary>
public class ComputerFacade(Computer computer)
{
    private readonly Computer _computer = computer
        ?? throw new ArgumentNullException(nameof(computer), "computer cannot be null");

    public void TurnOn()
    {
        _computer.GetElectricShock();
        _computer.MakeSound();
        _computer.ShowLoadingScreen();
        _computer.Bam();
    }

    public void TurnOff()
    {
        _computer.CloseEverything();
        _computer.PullCurrent();
        _computer.Sooth();
    }
}
