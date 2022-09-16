using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace _3._1_ABP.vNext框架介绍;

public class vNext框架介绍WebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<vNext框架介绍WebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
