using Albert.Abp.Console.Plugin.Abstract;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.DependencyInjection;

namespace Albert.Abp.Console.Plugin;

[Dependency(ServiceLifetime.Transient)]
public class PluginService:IPluginService
{
    public void PrintClassInfo()
    {
        System.Console.WriteLine("我是模块A的服务，已经开始.....");
    }
}