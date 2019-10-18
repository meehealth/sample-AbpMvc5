using Abp.AutoMapper;
using AbpMvc5.Sessions.Dto;

namespace AbpMvc5.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}