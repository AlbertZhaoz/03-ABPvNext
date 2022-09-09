using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Autofac;
using Volo.Abp.Dapper;
using Volo.Abp.Modularity;

namespace _3._1_ABP.vNext框架介绍
{
    [DependsOn(typeof(AbpAutofacModule),typeof(AbpDapperModule))]
    internal class AppModule:AbpModule
    {
        // 应用初始化
        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            base.OnApplicationInitialization(context);
        }

        // 服务注入
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);
        }
    }
}
