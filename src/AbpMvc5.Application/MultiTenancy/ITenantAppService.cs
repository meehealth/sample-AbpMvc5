using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AbpMvc5.MultiTenancy.Dto;

namespace AbpMvc5.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
