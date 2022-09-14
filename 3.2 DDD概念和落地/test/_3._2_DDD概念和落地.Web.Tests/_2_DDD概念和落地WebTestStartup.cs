using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace _3._2_DDD概念和落地;

public class _2_DDD概念和落地WebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<_2_DDD概念和落地WebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
