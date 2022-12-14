// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Modeling;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.Abp.AspNetCore.Mvc.ApplicationConfigurations;

// ReSharper disable once CheckNamespace
namespace Volo.Abp.AspNetCore.Mvc.ApplicationConfigurations.ClientProxies;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(IAbpApplicationLocalizationAppService), typeof(AbpApplicationLocalizationClientProxy))]
public partial class AbpApplicationLocalizationClientProxy : ClientProxyBase<IAbpApplicationLocalizationAppService>, IAbpApplicationLocalizationAppService
{
    public virtual async Task<ApplicationLocalizationDto> GetAsync(ApplicationLocalizationRequestDto input)
    {
        return await RequestAsync<ApplicationLocalizationDto>(nameof(GetAsync), new ClientProxyRequestTypeValue
        {
            { typeof(ApplicationLocalizationRequestDto), input }
        });
    }
}
