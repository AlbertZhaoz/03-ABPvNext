using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Volo.Abp.DependencyInjection;

namespace _3._4_DI_Options.Console;

[Volo.Abp.DependencyInjection.Dependency(ServiceLifetime.Transient)]
public class AlbertService:IAlbertService
{
    private readonly AlbertOptions _options;
    
    public AlbertService(IOptions<AlbertOptions> options)
    {
        _options = options.Value;
    }
    
    public void PrintName()
    {
        System.Console.WriteLine($"Hello,{_options.SubName}");
    }
}

[Volo.Abp.DependencyInjection.Dependency(ServiceLifetime.Transient)]
[DisableConventionalRegistration]
public class DisAlbertService : IAlbertService
{
    private readonly AlbertOptions _options;
    
    public DisAlbertService(IOptions<AlbertOptions> options)
    {
        _options = options.Value;
    }
    
    public void PrintName()
    {
        System.Console.WriteLine($"Hello,{_options.SubName}");
    }
}