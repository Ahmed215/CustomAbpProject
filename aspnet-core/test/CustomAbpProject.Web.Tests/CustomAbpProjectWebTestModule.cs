using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CustomAbpProject.EntityFrameworkCore;
using CustomAbpProject.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace CustomAbpProject.Web.Tests
{
    [DependsOn(
        typeof(CustomAbpProjectWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class CustomAbpProjectWebTestModule : AbpModule
    {
        public CustomAbpProjectWebTestModule(CustomAbpProjectEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CustomAbpProjectWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(CustomAbpProjectWebMvcModule).Assembly);
        }
    }
}