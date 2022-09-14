using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace _3._2_DDD概念和落地.Data;

/* This is used if database provider does't define
 * I_2_DDD概念和落地DbSchemaMigrator implementation.
 */
public class Null_2_DDD概念和落地DbSchemaMigrator : I_2_DDD概念和落地DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
