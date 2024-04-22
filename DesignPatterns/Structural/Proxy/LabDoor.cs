namespace DesignPatterns.Structural.Proxy;

public class LabDoor : IDoor
{
    public void Close() => Console.WriteLine($"Closing {nameof(LabDoor)}");

    public void Open() => Console.WriteLine($"Opening {nameof(LabDoor)}");
}
