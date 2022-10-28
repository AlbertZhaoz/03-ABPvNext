using Albert.Abp.WebApi;
using Volo.Abp;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// 模块类加载是在 AddApplication 中被加载的（源码阅读）
// 模块类加载:https://github.com/AlbertZhaoz/03-ABPvNext/blob/master/3.0%20ABP.vNext%20SourceCode/framework/src/Volo.Abp.Core/Volo/Abp/Modularity/ModuleLoader.cs
// AddApplication扩展方法:https://github.com/AlbertZhaoz/03-ABPvNext/blob/master/3.0%20ABP.vNext%20SourceCode/framework/src/Volo.Abp.Core/Microsoft/Extensions/DependencyInjection/ServiceCollectionApplicationExtensions.cs
builder.Services.AddApplication<AppModule>(opt=>
{
    // 替换默认配置
    opt.Services.ReplaceConfiguration(builder.Configuration);
    // 使用 Autofac
    opt.UseAutofac();
});


var app = builder.Build();

// Configure the HTTP request pipeline.
// 中间件初始化使用
app.InitializeApplication();
app.Run();