using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using _3._2_DDD概念和落地.Data;
using Volo.Abp.DependencyInjection;

namespace _3._2_DDD概念和落地.EntityFrameworkCore;

public class EntityFrameworkCore_2_DDD概念和落地DbSchemaMigrator
    : I_2_DDD概念和落地DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCore_2_DDD概念和落地DbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the _2_DDD概念和落地DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<_2_DDD概念和落地DbContext>()
            .Database
            .MigrateAsync();
    }
}
