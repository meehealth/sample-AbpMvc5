using System.Collections.Generic;
using AbpMvc5.Roles.Dto;
using AbpMvc5.Users.Dto;

namespace AbpMvc5.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}