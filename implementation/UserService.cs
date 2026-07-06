namespace implementation;

interface IUserService
{
    Task<List<string>> ListUsersAsync(string documentId);
}

public class UserService : IUserService
{
    public async Task<List<string>> ListUsersAsync(string documentId)
    {
        // Fetch users permission scoped to the tenant of the documentId

        // return a list of users that can be tagged in the current document
        return new List<string>();
    }
}