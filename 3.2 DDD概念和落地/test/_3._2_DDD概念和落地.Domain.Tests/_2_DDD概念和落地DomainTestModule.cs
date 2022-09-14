using _3._2_DDD概念和落地.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace _3._2_DDD概念和落地;

[DependsOn(
    typeof(_2_DDD概念和落地EntityFrameworkCoreTestModule)
    )]
public class _2_DDD概念和落地DomainTestModule : AbpModule
{

}
