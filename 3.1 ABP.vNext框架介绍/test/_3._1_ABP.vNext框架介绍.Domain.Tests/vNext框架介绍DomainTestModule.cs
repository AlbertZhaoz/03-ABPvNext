using _3._1_ABP.vNext框架介绍.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace _3._1_ABP.vNext框架介绍;

[DependsOn(
    typeof(vNext框架介绍EntityFrameworkCoreTestModule)
    )]
public class vNext框架介绍DomainTestModule : AbpModule
{

}
