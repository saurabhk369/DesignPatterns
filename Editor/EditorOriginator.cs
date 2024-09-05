namespace EditorMemento;

public class EditorOriginator
{
    private string Content = String.Empty;

    public EditorStateMemento CreateState() => new (Content);

    public void Restore(EditorStateMemento state) => Content = state.Content;

    public string GetContent() => Content;

    public void SetContent(string content) => Content = content;
}
