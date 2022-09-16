using _3._1_ABP.vNext框架介绍.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace _3._1_ABP.vNext框架介绍.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(vNext框架介绍EntityFrameworkCoreModule),
    typeof(vNext框架介绍ApplicationContractsModule)
    )]
public class vNext框架介绍DbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
