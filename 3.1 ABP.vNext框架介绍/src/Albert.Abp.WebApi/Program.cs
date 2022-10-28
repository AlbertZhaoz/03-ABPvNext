using Albert.Abp.WebApi;
using Autofac.Extensions.DependencyInjection;
using Volo.Abp;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApplication<AppModule>(opt=>
{
    // 用来替换默认配置
    opt.Services.ReplaceConfiguration(builder.Configuration);
    // 启用 Autofac
    opt.UseAutofac();
});


var app = builder.Build();

// Configure the HTTP request pipeline.
// 使用 Abp的初始化使用中间件
app.InitializeApplication();
app.Run();
