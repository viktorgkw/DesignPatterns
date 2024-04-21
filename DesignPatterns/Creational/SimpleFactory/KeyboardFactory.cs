namespace DesignPatterns.Creational.SimpleFactory;

/// <summary>
/// When creating an object is not just a few assignments and involves some logic, it makes sense to put it in a dedicated factory instead of repeating the same code everywhere.
/// </summary>
public static class KeyboardFactory
{
    public static IKeyboard CreateKeyboard(bool isMechanical, string layout)
        => isMechanical
            ? new MechanicalKeyboard(layout)
            : new MembraneKeyboard(layout);
}
