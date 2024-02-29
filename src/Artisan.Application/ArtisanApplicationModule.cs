using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Artisan.Authorization;

namespace Artisan
{
    [DependsOn(
        typeof(ArtisanCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ArtisanApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ArtisanAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ArtisanApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
