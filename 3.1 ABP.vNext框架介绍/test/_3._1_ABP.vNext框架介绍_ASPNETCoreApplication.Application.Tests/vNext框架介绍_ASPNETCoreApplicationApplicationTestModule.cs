using Volo.Abp.Modularity;

namespace _3._1_ABP.vNext框架介绍_ASPNETCoreApplication;

[DependsOn(
    typeof(vNext框架介绍_ASPNETCoreApplicationApplicationModule),
    typeof(vNext框架介绍_ASPNETCoreApplicationDomainTestModule)
    )]
public class vNext框架介绍_ASPNETCoreApplicationApplicationTestModule : AbpModule
{

}
