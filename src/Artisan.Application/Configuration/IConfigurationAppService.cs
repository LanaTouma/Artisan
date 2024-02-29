using System.Threading.Tasks;
using Artisan.Configuration.Dto;

namespace Artisan.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
