using _3._1_ABP.vNext框架介绍.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace _3._1_ABP.vNext框架介绍.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class vNext框架介绍Controller : AbpControllerBase
{
    protected vNext框架介绍Controller()
    {
        LocalizationResource = typeof(vNext框架介绍Resource);
    }
}
