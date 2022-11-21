using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Abp.Albert.Bussiness.Blazor;

[Dependency(ReplaceServices = true)]
public class BussinessBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Bussiness";
}
