namespace DocumentMemento;

public enum ChangeTypes
{
    Content,
    FontName,
    FontSize
}

public class DocumentState(ChangeTypes change, string value)
{
    public readonly KeyValuePair<ChangeTypes, string> state = new(change, value);

    public KeyValuePair<ChangeTypes, string> GetState() => state;
}
