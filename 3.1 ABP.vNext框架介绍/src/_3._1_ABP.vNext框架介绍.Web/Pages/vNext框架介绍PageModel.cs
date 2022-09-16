using _3._1_ABP.vNext框架介绍.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace _3._1_ABP.vNext框架介绍.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class vNext框架介绍PageModel : AbpPageModel
{
    protected vNext框架介绍PageModel()
    {
        LocalizationResourceType = typeof(vNext框架介绍Resource);
    }
}
