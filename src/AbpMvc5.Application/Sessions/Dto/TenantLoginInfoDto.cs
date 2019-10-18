using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using AbpMvc5.MultiTenancy;

namespace AbpMvc5.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}