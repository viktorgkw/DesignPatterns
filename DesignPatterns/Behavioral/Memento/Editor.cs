namespace DesignPatterns.Behavioral.Memento;

/// <summary>
/// Memento pattern is about capturing and storing the current state of an object in a manner that it can be restored later on in a smooth manner.
/// </summary>
public class Editor
{
    private string _content = string.Empty;
    private EditorMemento _memento = new(string.Empty);

    public void Type(string words) => _content += words;

    public string Content
    {
        get
        {
            return _content;
        }
    }

    public void Save()
    {
        _memento = new EditorMemento(_content);
    }

    public void Restore()
    {
        _content = _memento.Content;
    }
}
