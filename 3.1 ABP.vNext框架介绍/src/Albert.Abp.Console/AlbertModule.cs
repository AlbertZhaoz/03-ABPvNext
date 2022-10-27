using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Albert.Abp.Console;

[DependsOn(typeof(AbpAutofacModule))]
public class AlbertModule:AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHostedService<AlbertHostedService>();
    }
}