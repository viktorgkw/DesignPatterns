namespace DesignPatterns.Creational.SimpleFactory;

public class MembraneKeyboard(string layout) : IKeyboard
{
    private readonly string _layout = layout;

    public void GetLayout() => Console.WriteLine($"The keyboard's layout is {_layout}.");
}
