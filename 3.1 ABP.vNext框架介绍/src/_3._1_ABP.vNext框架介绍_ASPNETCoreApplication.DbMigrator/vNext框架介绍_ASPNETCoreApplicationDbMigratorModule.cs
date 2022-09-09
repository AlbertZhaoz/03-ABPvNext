using _3._1_ABP.vNext框架介绍_ASPNETCoreApplication.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace _3._1_ABP.vNext框架介绍_ASPNETCoreApplication.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(vNext框架介绍_ASPNETCoreApplicationEntityFrameworkCoreModule),
    typeof(vNext框架介绍_ASPNETCoreApplicationApplicationContractsModule)
    )]
public class vNext框架介绍_ASPNETCoreApplicationDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
