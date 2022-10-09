using Volo.Abp.DependencyInjection;

namespace _3._3_ABP.vNext模块化.Console;

// 取消自动注入
[DisableConventionalRegistration]
public class DisableUserService:ITransientDependency,IDisableUserService
{
    public void SayHello(string name = "albertzhao")
    {
        System.Console.WriteLine(name);
    }
}

public interface IDisableUserService
{
    void SayHello(string name = "albertzhao");
}