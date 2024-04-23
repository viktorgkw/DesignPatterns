namespace DesignPatterns.Behavioral.Iterator;

public class RadioStation(float frequency)
{
    private readonly float _frequency = frequency;

    public float GetFrequecy() => _frequency;
}
