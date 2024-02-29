using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Artisan.Controllers
{
    public abstract class ArtisanControllerBase: AbpController
    {
        protected ArtisanControllerBase()
        {
            LocalizationSourceName = ArtisanConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
