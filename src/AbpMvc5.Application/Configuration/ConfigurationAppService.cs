using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AbpMvc5.Configuration.Dto;

namespace AbpMvc5.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AbpMvc5AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
