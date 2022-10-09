using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Volo.Abp.DependencyInjection;

namespace _3._3_ABP.vNext模块化.Console;

public class UserService:ITransientDependency
{
    private readonly AlbertOptions _options;

    // 这里传入的是IOptions<TOptions> xxx
    public UserService(IOptions<AlbertOptions> options)
    {
        _options = options.Value;
    }
    public string SayHello(string name)
    {
        return $"hello, {name}";
    }

    public string SayHelloFromOptions()
    {
        if (_options.IsEnable)
        {
            return $"hello, {_options.Name}";
        }
        else
        {
            return $"hello, null";
        }
        
    }
}

[Dependency(ServiceLifetime.Singleton)]
// 指定实现哪一个接口
// [ExposeServices(typeof(xxxx))] 
public class GuidService
{
    private readonly Guid _guid;

    public GuidService()
    {
        _guid = Guid.NewGuid();
    }

    public void PrintGuid()
    {
        System.Console.WriteLine(_guid);
    }
}