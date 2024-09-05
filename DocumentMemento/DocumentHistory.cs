namespace DocumentMemento;

public class DocumentHistory
{
    private List<DocumentState> History = [];

    public void Push(DocumentState state)
        => History.Add(state);

    public DocumentState Pop()
    {
        int lastIndex = History.Count - 1;
        DocumentState state = History[lastIndex];
        History.RemoveAt(lastIndex);
        return state;
    }
}
