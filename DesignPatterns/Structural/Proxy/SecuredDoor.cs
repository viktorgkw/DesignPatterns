namespace DesignPatterns.Structural.Proxy;

public class SecuredDoor(IDoor door) : IDoor
{
    private readonly IDoor _door = door
        ?? throw new ArgumentNullException(nameof(door), "door can not be null");

    public void Open(string password)
    {
        if (Authenticate(password))
        {
            _door.Open();
        }
        else
        {
            Console.WriteLine("Big no! It ain't possible.");
        }
    }

    private bool Authenticate(string password)
    {
        return password == "$ecr@t";
    }

    public void Close()
    {
        _door.Close();
    }

    public void Open() { }
}
