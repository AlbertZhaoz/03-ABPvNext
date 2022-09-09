﻿using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.Authorization;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Data;
using Volo.Abp.IdentityServer;
using Volo.Abp.Modularity;
using Volo.Abp.Threading;

namespace _3._1_ABP.vNext框架介绍_ASPNETCoreApplication;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpTestBaseModule),
    typeof(AbpAuthorizationModule),
    typeof(vNext框架介绍_ASPNETCoreApplicationDomainModule)
    )]
public class vNext框架介绍_ASPNETCoreApplicationTestBaseModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<AbpIdentityServerBuilderOptions>(options =>
        {
            options.AddDeveloperSigningCredential = false;
        });

        PreConfigure<IIdentityServerBuilder>(identityServerBuilder =>
        {
            identityServerBuilder.AddDeveloperSigningCredential(false, System.Guid.NewGuid().ToString());
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options =>
        {
            options.IsJobExecutionEnabled = false;
        });

        context.Services.AddAlwaysAllowAuthorization();
    }

    public override void OnApplicationInitialization(ApplicationInitializationContext context)
    {
        SeedTestData(context);
    }

    private static void SeedTestData(ApplicationInitializationContext context)
    {
        AsyncHelper.RunSync(async () =>
        {
            using (var scope = context.ServiceProvider.CreateScope())
            {
                await scope.ServiceProvider
                    .GetRequiredService<IDataSeeder>()
                    .SeedAsync();
            }
        });
    }
}
