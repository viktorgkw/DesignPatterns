namespace DesignPatterns.Creational.SimpleFactory;

public static class KeyboardFactory
{
    public static IKeyboard CreateKeyboard(bool isMechanical, string layout)
        => isMechanical
            ? new MechanicalKeyboard
            {
                Layout = layout
            }
            : new MembraneKeyboard
            {
                Layout = layout
            };
}
