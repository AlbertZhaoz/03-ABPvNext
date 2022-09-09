using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace _3._1_ABP.vNext框架介绍_ASPNETCoreApplication.Data;

/* This is used if database provider does't define
 * IvNext框架介绍_ASPNETCoreApplicationDbSchemaMigrator implementation.
 */
public class NullvNext框架介绍_ASPNETCoreApplicationDbSchemaMigrator : IvNext框架介绍_ASPNETCoreApplicationDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
