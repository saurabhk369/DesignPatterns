namespace EditorMemento;

public class EditorStateMemento(string content)
{

    public readonly string Content = content;

    public string GetContent()
    {
        return Content;
    }
}
