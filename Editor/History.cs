namespace EditorMemento;

public class History
{
    private List<EditorStateMemento> Mementos = [];

    public void Push(EditorStateMemento memento) => Mementos.Add(memento);

    public EditorStateMemento Pop()
    {
        int lastIndex = Mementos.Count - 1;
        EditorStateMemento lastState = Mementos[lastIndex];
        Mementos.RemoveAt(lastIndex);
        return lastState;
    }
}
