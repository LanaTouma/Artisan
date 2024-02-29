using Abp.Authorization;
using Artisan.Authorization.Roles;
using Artisan.Authorization.Users;

namespace Artisan.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
