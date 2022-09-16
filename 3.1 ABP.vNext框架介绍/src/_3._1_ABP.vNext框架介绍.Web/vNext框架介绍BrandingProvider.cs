using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace _3._1_ABP.vNext框架介绍.Web;

[Dependency(ReplaceServices = true)]
public class vNext框架介绍BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "vNext框架介绍";
}
