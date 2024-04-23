namespace DesignPatterns.Behavioral.Observer;

public class Unsubscriber<JobPost>(
    ICollection<IObserver<JobPost>> observers,
    IObserver<JobPost> observer) : IDisposable
{
    private readonly ICollection<IObserver<JobPost>> _observers = observers;
    private readonly IObserver<JobPost> _observer = observer;

    public void Dispose() => _observers.Remove(_observer);
}
