using UserPermissions.Models;

namespace UserPermissions.UserDecorators;

public class AdminRole : UserDecorator
{
    public AdminRole(IUser user) : base(user) { }

    public override string GetPermissions()
    {
        return $"{User.GetPermissions()}, Manage Users";
    }
}
