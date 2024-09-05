using DocumentMemento;

namespace DocumentMementoTests;

[TestFixture]
public class DocumentMementoTests
{
    private Document Document;
    private DocumentHistory History;

    [OneTimeSetUp]
    public void Setup()
    {
        Document = new();
        History = new ();
    }

    [Test]
    public void AddingContent_ShouldAddContent()
    {
        Document.SetContent(new(ChangeTypes.Content, "Saurabh"));
        History.Push(Document.CreateState());
        var content = Document.GetContent();
        Assert.That(content, Is.EqualTo(new KeyValuePair<ChangeTypes, string>(ChangeTypes.Content, "Saurabh")));
    }

    [Test]
    public void ChangingFontName_ShouldAddFontNameToHistory()
    {
        Document.SetContent(new(ChangeTypes.FontName, "Arial"));
        History.Push(Document.CreateState());
        var content = Document.GetContent();
        Assert.That(content, Is.EqualTo(new KeyValuePair<ChangeTypes, string>(ChangeTypes.FontName, "Arial")));
    }

    [Test]
    public void ChangingFontSize_ShouldAddFontSizeToHistory()
    {
        Document.SetContent(new(ChangeTypes.FontSize, "20"));
        History.Push(Document.CreateState());
        var content = Document.GetContent();
        Assert.That(content, Is.EqualTo(new KeyValuePair<ChangeTypes, string>(ChangeTypes.FontSize, "20")));

        Document.SetContent(new(ChangeTypes.Content, "Saurabh Kulkarni"));
    }

    [Test]
    public void RestoringState_ShouldLoadPreviousEdit()
    {
        Document.Restore(History.Pop());
        var content = Document.GetContent();
        Assert.That(content, Is.EqualTo(new KeyValuePair<ChangeTypes, string>(ChangeTypes.FontSize, "20")));
    }
}
