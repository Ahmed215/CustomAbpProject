using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using CustomAbpProject.Configuration.Dto;

namespace CustomAbpProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CustomAbpProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
