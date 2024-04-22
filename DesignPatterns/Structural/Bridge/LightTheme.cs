namespace DesignPatterns.Structural.Bridge;

public class LightTheme : ITheme
{
    public string GetTheme() => GetType().Name;
}
