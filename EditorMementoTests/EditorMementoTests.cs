using EditorMemento;

namespace EditorMementoTests;

[TestFixture]
internal class EditorMementoTests
{
    private EditorOriginator Editor;
    private History History;

    [OneTimeSetUp]
    public void Setup()
    {
        Editor = new();
        History = new();
    }

    [Test]
    public void AddingContent_ShouldAddContent()
    {
        Editor.SetContent("A");
        History.Push(Editor.CreateState());
        string content = Editor.GetContent();
        Assert.That(content, Is.EqualTo("A"));

        Editor.SetContent("B");
        History.Push(Editor.CreateState());
        content = Editor.GetContent();
        Assert.That(content, Is.EqualTo("B"));

        Editor.SetContent("C");
    }

    [Test]
    public void RemoveingContent_ShouldUndoContent()
    {
        Editor.Restore(History.Pop());
        string content = Editor.GetContent();
        Assert.That(content, Is.EqualTo("B"));

        Editor.Restore(History.Pop());
        content = Editor.GetContent();
        Assert.That(content, Is.EqualTo("A"));
    }
}
