namespace DesignPatterns.Behavioral.Memento;

public class EditorMemento(string content)
{
    private readonly string _content = content;

    public string Content
    {
        get => _content;
    }
}
