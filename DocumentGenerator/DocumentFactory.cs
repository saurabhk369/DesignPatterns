using DocumentGenerator.DocumentFactories;

namespace DocumentGenerator;

public enum DocumentTypes
{
    PDF,
    WORD,
    EXCEL
}

public static class DocumentFactory
{
    public static IDocument CreateDocument(DocumentTypes documentType) =>
        documentType switch
        {
            DocumentTypes.PDF => new PDFDocumentGenerator(),
            DocumentTypes.WORD => new WordDocumentGenerator(),
            DocumentTypes.EXCEL => new ExcelDocumentGenerator(),
            _ => throw new ArgumentException("Invalid document type"),
        };
}
