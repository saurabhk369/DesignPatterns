using UserPermissions.Models;

namespace UserPermissions.UserDecorators;

public class UserDecorator(IUser user) : IUser
{
    protected IUser User = user;
    public virtual string GetPermissions() => User.GetPermissions();
}
