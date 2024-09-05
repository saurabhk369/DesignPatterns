using UserPermissions.Models;

namespace UserPermissions.UserDecorators;

public class EditorRole : UserDecorator
{
    public EditorRole(IUser user) : base(user) { }

    public override string GetPermissions()
    {
        return $"{User.GetPermissions()}, Edit Content";
    }
}
