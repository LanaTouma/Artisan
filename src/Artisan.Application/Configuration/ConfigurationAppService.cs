using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Artisan.Configuration.Dto;

namespace Artisan.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ArtisanAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
