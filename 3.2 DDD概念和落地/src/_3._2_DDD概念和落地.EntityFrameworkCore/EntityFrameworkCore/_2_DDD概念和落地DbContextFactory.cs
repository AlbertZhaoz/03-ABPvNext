using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace _3._2_DDD概念和落地.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class _2_DDD概念和落地DbContextFactory : IDesignTimeDbContextFactory<_2_DDD概念和落地DbContext>
{
    public _2_DDD概念和落地DbContext CreateDbContext(string[] args)
    {
        _2_DDD概念和落地EfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<_2_DDD概念和落地DbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new _2_DDD概念和落地DbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../_3._2_DDD概念和落地.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
