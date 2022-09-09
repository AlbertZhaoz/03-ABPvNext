using _3._1_ABP.vNext框架介绍_ASPNETCoreApplication.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace _3._1_ABP.vNext框架介绍_ASPNETCoreApplication.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class vNext框架介绍_ASPNETCoreApplicationController : AbpControllerBase
{
    protected vNext框架介绍_ASPNETCoreApplicationController()
    {
        LocalizationResource = typeof(vNext框架介绍_ASPNETCoreApplicationResource);
    }
}
