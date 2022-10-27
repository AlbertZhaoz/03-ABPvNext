using Volo.Abp;
using Volo.Abp.Modularity;

namespace Albert.Abp.Console.Plugin;

public class PluginModule:AbpModule
{
    public override void OnApplicationInitialization(ApplicationInitializationContext context)
    {
        base.OnApplicationInitialization(context);
        System.Console.WriteLine("插件模块A运行");
    }
}