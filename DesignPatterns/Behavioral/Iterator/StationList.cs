using System.Collections;

namespace DesignPatterns.Behavioral.Iterator;

public class StationList : IEnumerable<RadioStation>
{
    private readonly List<RadioStation> _stations = [];

    public RadioStation this[int index]
    {
        get { return _stations[index]; }
        set { _stations.Insert(index, value); }
    }

    public void Add(RadioStation station) => _stations.Add(station);

    public void Remove(RadioStation station) => _stations.Remove(station);

    public IEnumerator<RadioStation> GetEnumerator()
    {
        foreach (var station in _stations)
            yield return station;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
