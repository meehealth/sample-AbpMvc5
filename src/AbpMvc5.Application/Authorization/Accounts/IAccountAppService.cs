using System.Threading.Tasks;
using Abp.Application.Services;
using AbpMvc5.Authorization.Accounts.Dto;

namespace AbpMvc5.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
