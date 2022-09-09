using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using _3._1_ABP.vNext框架介绍_ASPNETCoreApplication.Data;
using Volo.Abp.DependencyInjection;

namespace _3._1_ABP.vNext框架介绍_ASPNETCoreApplication.EntityFrameworkCore;

public class EntityFrameworkCorevNext框架介绍_ASPNETCoreApplicationDbSchemaMigrator
    : IvNext框架介绍_ASPNETCoreApplicationDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCorevNext框架介绍_ASPNETCoreApplicationDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the vNext框架介绍_ASPNETCoreApplicationDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<vNext框架介绍_ASPNETCoreApplicationDbContext>()
            .Database
            .MigrateAsync();
    }
}
