using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace _3._1_ABP.vNext框架介绍.ConsolePlug
{
    [DependsOn(typeof(AbpAutofacModule))]
    public class AppModule:AbpModule
    {
        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var content = context.ServiceProvider.GetRequiredService<AlbertPrintService>().ReadFile().Result;
            Console.WriteLine(content);
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);
        }
    }
}
