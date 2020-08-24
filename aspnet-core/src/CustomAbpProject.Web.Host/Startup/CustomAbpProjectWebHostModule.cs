using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CustomAbpProject.Configuration;

namespace CustomAbpProject.Web.Host.Startup
{
    [DependsOn(
       typeof(CustomAbpProjectWebCoreModule))]
    public class CustomAbpProjectWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public CustomAbpProjectWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CustomAbpProjectWebHostModule).GetAssembly());
        }
    }
}
