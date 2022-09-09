using _3._1_ABP.vNext框架介绍;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;

using (var app=AbpApplicationFactory.Create<AppModule>(opt=>
       {
           opt.UseAutofac();
       }))
{
    app.Initialize();

    Console.WriteLine( app.Services.GetRequiredService<AlbertPrintService>().ReadFile());
}
