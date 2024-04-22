namespace DesignPatterns.Structural.Adapter;

public class Hunter
{
    public void Hunt(ILion lion) => Console.WriteLine($"Running to hunt...");
}
