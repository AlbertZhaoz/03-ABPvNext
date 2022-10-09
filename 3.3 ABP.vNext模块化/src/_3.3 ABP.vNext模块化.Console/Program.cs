using _3._3_ABP.vNext模块化.Console;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Volo.Abp;

using (var app = AbpApplicationFactory.Create<AppModule>())
{
    app.Initialize();

    // 获取配置选项
    var optionName = app.ServiceProvider.GetService<IOptions<AlbertOptions>>().Value.Name;
    Console.WriteLine(optionName);
    
    var selfService = app.ServiceProvider.GetRequiredService<UserService>();
    Console.WriteLine(selfService.SayHelloFromOptions());
    Console.WriteLine(selfService.SayHello("alphabetizer"));
    // 用来测试是否被禁用自动注册服务
    //app.ServiceProvider.GetService<DisableUserService>().SayHello();
    Console.WriteLine("==========");
    app.ServiceProvider.GetService<GuidService>().PrintGuid();
    app.ServiceProvider.GetService<GuidService>().PrintGuid();
    app.ServiceProvider.GetService<GuidService>().PrintGuid();
    app.ServiceProvider.GetService<GuidService>().PrintGuid();

    // 模块类已经被默认被注册进去了，为单例模式。
    var moduleServices = app.ServiceProvider.GetService<AppModule>();
    Console.WriteLine(moduleServices.ToString());
}