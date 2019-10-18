using System.Collections.Generic;
using System.Linq;
using AbpMvc5.Roles.Dto;
using AbpMvc5.Users.Dto;

namespace AbpMvc5.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.Roles != null && User.Roles.Any(r => r == role.Name);
        }
    }
}