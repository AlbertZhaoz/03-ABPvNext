using _3._1_ABP.vNext框架介绍_ASPNETCoreApplication.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace _3._1_ABP.vNext框架介绍_ASPNETCoreApplication.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class vNext框架介绍_ASPNETCoreApplicationPageModel : AbpPageModel
{
    protected vNext框架介绍_ASPNETCoreApplicationPageModel()
    {
        LocalizationResourceType = typeof(vNext框架介绍_ASPNETCoreApplicationResource);
    }
}
