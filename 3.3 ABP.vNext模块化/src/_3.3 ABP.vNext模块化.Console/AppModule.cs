using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace _3._3_ABP.vNext模块化.Console;

public class AppModule:AbpModule
{
    public AppModule()
    {
        // 跳过自动注入，将不会进行服务注入，必须得手动
        SkipAutoServiceRegistration = true;
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        if (SkipAutoServiceRegistration)
        {
            // 可以将程序集合中所有符合条件的服务自动注入
            context.Services.AddAssemblyOf<AppModule>();
        }
        
        Configure<AlbertOptions>(opt =>
        {
            opt.IsEnable = true;
            opt.Num = 10086;
            opt.Name = "AlbertZhao";
        });
    }
}