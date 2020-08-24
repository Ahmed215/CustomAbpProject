using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CustomAbpProject.Authorization;

namespace CustomAbpProject
{
    [DependsOn(
        typeof(CustomAbpProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CustomAbpProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<CustomAbpProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CustomAbpProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
