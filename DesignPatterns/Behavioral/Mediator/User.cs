namespace DesignPatterns.Behavioral.Mediator;

public class User(string name, IChatRoomMediator chatroom)
{
    private readonly string _name = name;
    private readonly IChatRoomMediator _chatRoom = chatroom;

    public string GetName() => _name;

    public void Send(string message) => _chatRoom.ShowMessage(this, message);
}
