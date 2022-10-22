using Albert.Novel.Domain;
using Volo.Abp;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Albert.Novel.TestBase;

[DependsOn(typeof(AbpAutofacModule),
    typeof(AbpTestBaseModule),
    typeof(NovelDomainModule))]
public class NovelTestBaseModule:AbpModule
{
    
}