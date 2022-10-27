using Albert.Abp.Console;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Volo.Abp;
using Volo.Abp.Modularity.PlugIns;

Console.WriteLine("Console Start....");

// 托管服务调用
Host.CreateDefaultBuilder(args)
    .UseAutofac()
    .ConfigureServices((hostContext, services) =>
    {
        services.AddApplication<AlbertModule>(opt =>
        {
            // 这边增加插件管理
            var path = $"{AppDomain.CurrentDomain.BaseDirectory}ModulePlugins";
            opt.PlugInSources.AddFolder(path);
        });
    }).RunConsoleAsync().Wait();

// 直接使用模块创建而后调用服务
// using (var app=AbpApplicationFactory.Create<AlbertModule>(opt=>
//        {
//            // 使用Autofac
//            opt.UseAutofac();
//        }))
// {
//     app.Initialize();
//     Console.WriteLine("我是Program里面执行的");
//     // 服务调用
//     app.Services.GetRequiredService<AlbertHService>().SayHello();
// }