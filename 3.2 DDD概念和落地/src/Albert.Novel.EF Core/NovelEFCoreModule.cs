using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.SqlServer;
using Volo.Abp.Modularity;

namespace Albert.Novel.EF_Core;

[DependsOn(typeof(AbpEntityFrameworkCoreModule)
,typeof(AbpEntityFrameworkCoreSqlServerModule))]
public class NovelEFCoreModule:AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        // 添加服务
        context.Services.AddAbpDbContext<NovelDbContext>(options =>
        {
            // 给聚合根（没有直接继承聚合根，而是 Entity<Guid> 也创建默认表。
            options.AddDefaultRepositories(true);
        });
        // 配置服务
        Configure<AbpDbContextOptions>(opt =>
        {
            opt.UseSqlServer();
        });
    }
}