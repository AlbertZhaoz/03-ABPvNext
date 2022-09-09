using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace _3._1_ABP.vNext框架介绍_ASPNETCoreApplication.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class vNext框架介绍_ASPNETCoreApplicationDbContextFactory : IDesignTimeDbContextFactory<vNext框架介绍_ASPNETCoreApplicationDbContext>
{
    public vNext框架介绍_ASPNETCoreApplicationDbContext CreateDbContext(string[] args)
    {
        vNext框架介绍_ASPNETCoreApplicationEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<vNext框架介绍_ASPNETCoreApplicationDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new vNext框架介绍_ASPNETCoreApplicationDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../_3._1_ABP.vNext框架介绍_ASPNETCoreApplication.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
