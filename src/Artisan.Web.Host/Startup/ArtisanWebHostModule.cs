using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Artisan.Configuration;

namespace Artisan.Web.Host.Startup
{
    [DependsOn(
       typeof(ArtisanWebCoreModule))]
    public class ArtisanWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ArtisanWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ArtisanWebHostModule).GetAssembly());
        }
    }
}
