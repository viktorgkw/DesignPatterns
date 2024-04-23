namespace DesignPatterns.Behavioral.Mediator;

public class ChatRoom : IChatRoomMediator
{
    public void ShowMessage(User user, string message)
    {
        Console.WriteLine($"{DateTime.Now:MMMM dd, H:mm} [{user.GetName()}]: {message}");
    }
}
