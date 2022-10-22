using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.Modularity;
using Volo.Abp.Testing;
using Volo.Abp.Uow;

namespace Albert.Novel.TestBase;

// 继承集成测试的泛型类 AbpIntegratedTest (提供了开启工作单元的方法）
// uow工作单元提供了对我们应用程序中数据库连接和事务范围的一个抽象和控制（事务边界）
// where子句约束 TStartupModule 要实现 IAbpModule
public abstract class NovelTestBase<TStartupModule>:AbpIntegratedTest<TStartupModule> where TStartupModule:IAbpModule
{
    protected override void SetAbpApplicationCreationOptions(AbpApplicationCreationOptions options)
    {
        // 启用 autofac
        options.UseAutofac();
    }

    #region 开启工作单元
// 开启工作单元
    // options 配置工作单元的参数。
    // action 在工作单元执行的操作，通常为增删改查。
    protected virtual async Task WithUnitOfWorkAsync(AbpUnitOfWorkOptions options, Func<Task> action)
    {
        using (var scope = ServiceProvider.CreateScope())
        {
            var uowManager = scope.ServiceProvider.GetRequiredService<IUnitOfWorkManager>();

            using (var uow = uowManager.Begin(options))
            {
                await action();
                await uow.CompleteAsync();
            }
        }
    }

    protected virtual async Task<TResult> WithUnitOfWorkAsync<TResult>(AbpUnitOfWorkOptions options,Func<Task<TResult>> func)
    {
        using (var scope = ServiceProvider.CreateScope())
        {
            var uowManager = scope.ServiceProvider.GetRequiredService<IUnitOfWorkManager>();

            using (var uow = uowManager.Begin(options))
            {
                var result = await func();
                await uow.CompleteAsync();
                return result;
            }
        }
    }
    
    protected virtual Task WithUnitOfWorkAsync(Func<Task> func)
    {
        return WithUnitOfWorkAsync(new AbpUnitOfWorkOptions(), func);
    }
    
    protected virtual Task<TResult> WithUnitOfWorkAsync<TResult>(Func<Task<TResult>> func)
    {
        return WithUnitOfWorkAsync(new AbpUnitOfWorkOptions(), func);
    }
    #endregion
}