using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace CustomAbpProject.Controllers
{
    public abstract class CustomAbpProjectControllerBase: AbpController
    {
        protected CustomAbpProjectControllerBase()
        {
            LocalizationSourceName = CustomAbpProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
