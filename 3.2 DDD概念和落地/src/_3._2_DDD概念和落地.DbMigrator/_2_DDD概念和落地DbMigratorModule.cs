using _3._2_DDD概念和落地.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace _3._2_DDD概念和落地.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(_2_DDD概念和落地EntityFrameworkCoreModule),
    typeof(_2_DDD概念和落地ApplicationContractsModule)
    )]
public class _2_DDD概念和落地DbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
