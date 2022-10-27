using Albert.Abp.Console.Plugin.Abstract;
using Microsoft.Extensions.Hosting;

namespace Albert.Abp.Console;

public class AlbertHostedService:IHostedService
{
    // private readonly AlbertHService _albert;
    //
    // public AlbertHostedService(AlbertHService albert)
    // {
    //     this._albert = albert;
    // }

    // 属性注入
    public AlbertHService _albert { get; set; }
    
    // 插件属性插入
    public IPluginService _albertPlugin{ get; set; }
    
    public Task StartAsync(CancellationToken cancellationToken)
    {
        _albert.SayHello();

        _albertPlugin.PrintClassInfo();
        
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}