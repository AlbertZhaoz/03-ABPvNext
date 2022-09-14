using _3._2_DDD概念和落地.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace _3._2_DDD概念和落地.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class _2_DDD概念和落地PageModel : AbpPageModel
{
    protected _2_DDD概念和落地PageModel()
    {
        LocalizationResourceType = typeof(_2_DDD概念和落地Resource);
    }
}
