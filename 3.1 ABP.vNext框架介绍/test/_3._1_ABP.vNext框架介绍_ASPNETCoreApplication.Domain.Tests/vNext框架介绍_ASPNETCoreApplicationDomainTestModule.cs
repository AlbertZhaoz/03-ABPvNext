using _3._1_ABP.vNext框架介绍_ASPNETCoreApplication.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace _3._1_ABP.vNext框架介绍_ASPNETCoreApplication;

[DependsOn(
    typeof(vNext框架介绍_ASPNETCoreApplicationEntityFrameworkCoreTestModule)
    )]
public class vNext框架介绍_ASPNETCoreApplicationDomainTestModule : AbpModule
{

}
