using Abp.Authorization;
using CustomAbpProject.Authorization.Roles;
using CustomAbpProject.Authorization.Users;

namespace CustomAbpProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
