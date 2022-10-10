using Volo.Abp.Modularity;

namespace _3._4_DI_Options.Console;

public class AppModule:AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AlbertOptions>(opt =>
        {
            opt.IsEnable = true;
            opt.Num = 10086;
            opt.SubName = "AlbertWarning";
        });
    }
}