using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace _3._1_ABP.vNext框架介绍.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class vNext框架介绍DbContextFactory : IDesignTimeDbContextFactory<vNext框架介绍DbContext>
{
    public vNext框架介绍DbContext CreateDbContext(string[] args)
    {
        vNext框架介绍EfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<vNext框架介绍DbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new vNext框架介绍DbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../_3._1_ABP.vNext框架介绍.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
