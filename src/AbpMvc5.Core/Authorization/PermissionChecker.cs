using Abp.Authorization;
using AbpMvc5.Authorization.Roles;
using AbpMvc5.Authorization.Users;

namespace AbpMvc5.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
