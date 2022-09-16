using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using _3._1_ABP.vNext框架介绍.Data;
using Volo.Abp.DependencyInjection;

namespace _3._1_ABP.vNext框架介绍.EntityFrameworkCore;

public class EntityFrameworkCorevNext框架介绍DbSchemaMigrator
    : IvNext框架介绍DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCorevNext框架介绍DbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the vNext框架介绍DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<vNext框架介绍DbContext>()
            .Database
            .MigrateAsync();
    }
}
