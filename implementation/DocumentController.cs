namespace implementation;

public class DocumentController(IUserService userService, IDocumentService documentService) : ControllerBase
{
    // list users RBAC - tenant scoped
    [Get("/list-users{documentId:required}")]
    public async Tasl<IActionResult> ListUsersAsync(string documentId)
    {
        // service will return a list of users that can be tagged in the current document
        return Ok(await userService.ListUsersAsync(documentId));
    } 

    // save document with tags
    [Post("/save-document")] 
    public async Task<IActionResult> SaveDocumentAsync([FromBody] Document document)
    {
        // save the document - service will parse users tagged to be notified
        await documentService.SaveDocumentAsync(document);
    }       
}