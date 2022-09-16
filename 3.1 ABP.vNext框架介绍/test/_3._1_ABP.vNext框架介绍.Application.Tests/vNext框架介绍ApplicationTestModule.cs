using Volo.Abp.Modularity;

namespace _3._1_ABP.vNext框架介绍;

[DependsOn(
    typeof(vNext框架介绍ApplicationModule),
    typeof(vNext框架介绍DomainTestModule)
    )]
public class vNext框架介绍ApplicationTestModule : AbpModule
{

}
