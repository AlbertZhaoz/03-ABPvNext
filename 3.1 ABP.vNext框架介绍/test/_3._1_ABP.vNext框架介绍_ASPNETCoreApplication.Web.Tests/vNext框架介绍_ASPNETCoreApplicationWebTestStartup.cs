using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace _3._1_ABP.vNext框架介绍_ASPNETCoreApplication;

public class vNext框架介绍_ASPNETCoreApplicationWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<vNext框架介绍_ASPNETCoreApplicationWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
