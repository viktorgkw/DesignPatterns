namespace DesignPatterns.Behavioral.State;

/// <summary>
/// It lets you change the behavior of a class when the state changes.
/// </summary>
public class TextEditor
{
    private IWritingState _state = new DefaultText();

    public void SetState(IWritingState state) => _state = state;

    public void Type(string words) => _state.Write(words);
}
