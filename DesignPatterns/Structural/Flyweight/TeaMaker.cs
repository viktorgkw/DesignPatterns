namespace DesignPatterns.Structural.Flyweight;

public class TeaMaker
{
    private readonly Dictionary<string, KarakTea> _availableTea = [];

    public KarakTea Make(string preference)
    {
        if (!_availableTea.TryGetValue(preference, out KarakTea value))
        {
            value = new();
            _availableTea[preference] = value;
        }

        return value;
    }
}
