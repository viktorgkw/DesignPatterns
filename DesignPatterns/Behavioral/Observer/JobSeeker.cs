namespace DesignPatterns.Behavioral.Observer;

public class JobSeeker(string name) : IObserver<JobPost>
{
    public string Name { get; private set; } = name;

    public void OnCompleted() { }

    public void OnError(Exception error) { }

    public void OnNext(JobPost value)
        => Console.WriteLine($"Hello {Name}! New job has been posted -> {value.Title}");
}
