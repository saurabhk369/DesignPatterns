using DocumentGenerator;
using DocumentGenerator.DocumentFactories;

namespace DocumentGeneratorTests;

[TestFixture]
public class Tests
{
    [Test]
    public void PDFFactory_ShouldCreatePDF()
    {
        IDocument document = DocumentFactory.CreateDocument(DocumentTypes.PDF);
        string content = document.Generate();
        Assert.That(content, Is.EqualTo("PDF Generated"));
    }

    [Test]
    public void WordFactory_ShouldCreateWord()
    {
        IDocument document = DocumentFactory.CreateDocument(DocumentTypes.WORD);
        string content = document.Generate();
        Assert.That(content, Is.EqualTo("Word Generated"));
    }
    [Test]
    public void ExcelFactory_ShouldCreateExcel()
    {
        IDocument document = DocumentFactory.CreateDocument(DocumentTypes.EXCEL);
        string content = document.Generate();
        Assert.That(content, Is.EqualTo("Excel Generated"));
    }
}