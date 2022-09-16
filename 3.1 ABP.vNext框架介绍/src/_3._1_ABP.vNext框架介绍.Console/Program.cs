using _3._1_ABP.vNext框架介绍.Console;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.Modularity.PlugIns;

using var app=AbpApplicationFactory.Create<AppModule>(opt=>
{
    opt.UseAutofac();
    opt.PlugInSources.AddFolder(AppDomain.CurrentDomain.BaseDirectory+"Plugs");

});

Console.WriteLine("Added PlugIns Directory is completed.");
app.Initialize();
Console.WriteLine("Initialize DI is completed.");
Console.WriteLine("Run Console Module Method:");
Console.WriteLine(await app.Services.GetRequiredService<AlbertPrintService>().ReadFile());

Console.ReadKey();