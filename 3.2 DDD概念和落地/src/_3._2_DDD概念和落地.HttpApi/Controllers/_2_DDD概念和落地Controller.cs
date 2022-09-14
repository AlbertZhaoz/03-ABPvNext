using _3._2_DDD概念和落地.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace _3._2_DDD概念和落地.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class _2_DDD概念和落地Controller : AbpControllerBase
{
    protected _2_DDD概念和落地Controller()
    {
        LocalizationResource = typeof(_2_DDD概念和落地Resource);
    }
}
