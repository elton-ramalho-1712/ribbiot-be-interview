namespace implementation;

public interface IDocumentService
{
    Task SaveDocumentAsync(ITaggeable document);
}

public class DocumentService : IDocumentService
{
    public async Task SaveDocumentAsync(ITaggeable document)
    {
        // parse users to be notified
        var tags = ParserHelper.ParseTags(document);

        // fetch user additional information from DB - such as Device Id
        // Save to audit

        // On transaction commit use notificaton service to dispatch notifications to the users tagged in the document

        var tags = ParserHelper.ParseTags(string.Join(" ", document.Tags));
        // notify users tagged in the document
    }
}