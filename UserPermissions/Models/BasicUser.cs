namespace UserPermissions.Models;

public class BasicUser : IUser
{
    public string GetPermissions() => "View Content";
}
