using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace _3._2_DDD概念和落地.Web;

[Dependency(ReplaceServices = true)]
public class _2_DDD概念和落地BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "_2_DDD概念和落地";
}
