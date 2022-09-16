using _3._1_ABP.vNext框架介绍.ConsolePlug;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.Modularity.PlugIns;

using var app=AbpApplicationFactory.Create<AppModule>(opt=>
{
    opt.UseAutofac();
});
app.Initialize();
