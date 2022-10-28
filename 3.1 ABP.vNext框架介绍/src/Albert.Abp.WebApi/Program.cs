using Albert.Abp.WebApi;
using Autofac.Extensions.DependencyInjection;
using Volo.Abp;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApplication<AppModule>(opt=>
{
    // �����滻Ĭ������
    opt.Services.ReplaceConfiguration(builder.Configuration);
    // ���� Autofac
    opt.UseAutofac();
});


var app = builder.Build();

// Configure the HTTP request pipeline.
// ʹ�� Abp�ĳ�ʼ��ʹ���м��
app.InitializeApplication();
app.Run();
