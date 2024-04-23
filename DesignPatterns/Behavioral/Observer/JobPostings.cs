using System;

namespace DesignPatterns.Behavioral.Observer;

public class JobPostings : IObservable<JobPost>
{
    private readonly List<IObserver<JobPost>> _observers = [];
    private readonly List<JobPost> _jobPostings = [];

    public IDisposable Subscribe(IObserver<JobPost> observer)
    {
        if (!_observers.Contains(observer))
            _observers.Add(observer);

        return new Unsubscriber<JobPost>(_observers, observer);
    }

    public void AddJob(JobPost jobPost)
    {
        _jobPostings.Add(jobPost);
        Notify(jobPost);
    }

    private void Notify(JobPost jobPost)
    {
        foreach (var observer in _observers)
        {
            observer.OnNext(jobPost);
        }
    }
}
