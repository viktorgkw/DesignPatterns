namespace DesignPatterns.Structural.Bridge;

public class About(ITheme theme) : IWebPage
{
    private readonly ITheme _theme = theme;

    public string GetContent() => $"{GetType().Name} in {_theme.GetTheme()}.";
}
