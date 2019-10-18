using System.Threading.Tasks;
using Abp.Application.Services;
using AbpMvc5.Configuration.Dto;

namespace AbpMvc5.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}