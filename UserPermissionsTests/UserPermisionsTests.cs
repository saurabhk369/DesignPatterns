using UserPermissions.Models;
using UserPermissions.UserDecorators;

namespace UserPermissionsTest;

[TestFixture]
public class UserPermissionTests
{
    [Test]
    public void BasicUser_ShouldHaveViewContentPermission()
    {
        IUser user = new BasicUser();
        Assert.That(user.GetPermissions(), Is.EqualTo("View Content"));
    }

    [Test]
    public void BasicUserWithAdminRole_ShouldHaveManageUsersPermission()
    {
        IUser basicUser = new BasicUser();
        IUser admin = new AdminRole(basicUser);
        Assert.That(admin.GetPermissions, Is.EqualTo("View Content, Manage Users"));
    }

    [Test]
    public void BasicUserWithEditorRole_ShouldHaveEditContentPermission()
    {
        IUser basicUser = new BasicUser();
        IUser editor = new EditorRole(basicUser);
        Assert.That(editor.GetPermissions, Is.EqualTo("View Content, Edit Content"));
    }

    [Test]
    public void BasicUserWithAdminAndEditorRoles_ShouldHaveAllPermissions()
    {
        IUser basicUser = new BasicUser();
        IUser admin = new AdminRole(basicUser);
        IUser editor = new EditorRole(admin);
        Assert.That(editor.GetPermissions(), Is.EqualTo("View Content, Manage Users, Edit Content"));
    }
}