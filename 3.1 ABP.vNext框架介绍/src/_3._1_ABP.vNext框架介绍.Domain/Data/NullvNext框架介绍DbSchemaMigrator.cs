using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace _3._1_ABP.vNext框架介绍.Data;

/* This is used if database provider does't define
 * IvNext框架介绍DbSchemaMigrator implementation.
 */
public class NullvNext框架介绍DbSchemaMigrator : IvNext框架介绍DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
