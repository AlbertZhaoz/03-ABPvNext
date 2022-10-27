using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.DependencyInjection;

namespace Albert.Abp.Console;

// 最好通过特性来注册，实现接口违反了接口的单一职责原则
[Dependency(ServiceLifetime.Scoped)]
public class AlbertHService
{
    public void SayHello()
    {
        System.Console.WriteLine("Hi,I'm albert.");
    }
}