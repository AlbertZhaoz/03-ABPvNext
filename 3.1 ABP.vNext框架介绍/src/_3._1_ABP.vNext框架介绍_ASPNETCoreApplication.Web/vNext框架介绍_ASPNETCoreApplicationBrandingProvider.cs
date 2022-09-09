using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace _3._1_ABP.vNext框架介绍_ASPNETCoreApplication.Web;

[Dependency(ReplaceServices = true)]
public class vNext框架介绍_ASPNETCoreApplicationBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "vNext框架介绍_ASPNETCoreApplication";
}
