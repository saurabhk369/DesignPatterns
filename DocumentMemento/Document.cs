namespace DocumentMemento;

public class Document
{
    private KeyValuePair<ChangeTypes, string> Content = new();

    public DocumentState CreateState() => new(Content.Key, Content.Value);

    public void Restore(DocumentState state) => Content = state.state;

    public KeyValuePair<ChangeTypes, string> GetContent() => Content;

    public void SetContent(KeyValuePair<ChangeTypes, string> content) => Content = content;
}
