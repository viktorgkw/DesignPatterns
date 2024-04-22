namespace DesignPatterns.Structural.Bridge;

public class DarkTheme : ITheme
{
    public string GetTheme() => GetType().Name;
}
