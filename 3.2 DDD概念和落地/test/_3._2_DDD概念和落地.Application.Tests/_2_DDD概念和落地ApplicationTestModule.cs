using Volo.Abp.Modularity;

namespace _3._2_DDD概念和落地;

[DependsOn(
    typeof(_2_DDD概念和落地ApplicationModule),
    typeof(_2_DDD概念和落地DomainTestModule)
    )]
public class _2_DDD概念和落地ApplicationTestModule : AbpModule
{

}
