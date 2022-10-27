using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using NSubstitute.Extensions;
using Volo.Abp;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Sqlite;
using Volo.Abp.Modularity;

namespace Albert.Novel.EF_Core.Test
{
    [DependsOn(typeof(AbpEntityFrameworkCoreSqliteModule),
        typeof(NovelEFCoreModule),
        typeof(AbpTestBaseModule))]
    public class AlbertNovelEFCoreTestModule:AbpModule
    {
        private SqliteConnection _sqliteConnection;
        private static SqliteConnection CreateDataBaseAndGetConnection()
        {
            var connection = new SqliteConnection("Data Source=:memory:");
            connection.Open();
            var options = new DbContextOptionsBuilder<NovelDbContext>()
                .UseSqlite(connection)
                .Options;

            var context = new NovelDbContext(options);
            context.GetService<IRelationalDatabaseCreator>().CreateTables();

            return connection;
        }



        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            _sqliteConnection = CreateDataBaseAndGetConnection();
            context.Services.Configure<AbpDbContextOptions>(option=>
            {
                option.Configure(configurationContext =>configurationContext.DbContextOptions.UseSqlite(_sqliteConnection));
            });
        }

        public override void OnApplicationShutdown(ApplicationShutdownContext context)
        {
            _sqliteConnection.Dispose();
        }
    }
}
