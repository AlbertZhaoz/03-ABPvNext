using _3._4_DI_Options.Console;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;

using (var app = AbpApplicationFactory.Create<AppModule>())
{
    app.Initialize();

    var services = app.ServiceProvider.GetServices<IAlbertService>();
    foreach (var VARIABLE in services)
    {
        Console.WriteLine(VARIABLE.ToString());
    }

    var albertService = app.ServiceProvider.GetRequiredService<IAlbertService>();
    albertService.PrintName();
}