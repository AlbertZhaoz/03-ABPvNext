using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Autofac;
using Volo.Abp.Dapper;
using Volo.Abp.Modularity;

namespace _3._1_ABP.vNext框架介绍.Console
{
    [DependsOn(typeof(AbpAutofacModule))]
    public class AppModule:AbpModule
    {

    }
}
