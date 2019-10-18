using System.Threading.Tasks;
using Abp.Application.Services;
using AbpMvc5.Sessions.Dto;

namespace AbpMvc5.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
