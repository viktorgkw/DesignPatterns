namespace DesignPatterns.Creational.SimpleFactory;

public class MembraneKeyboard(string layout) : IKeyboard
{
    private readonly string _layout = layout;

    public string GetLayout() => _layout;
}
