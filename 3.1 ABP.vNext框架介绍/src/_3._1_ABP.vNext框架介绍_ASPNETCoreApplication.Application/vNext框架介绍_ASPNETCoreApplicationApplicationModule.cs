using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

namespace _3._1_ABP.vNext框架介绍_ASPNETCoreApplication;

[DependsOn(
    typeof(vNext框架介绍_ASPNETCoreApplicationDomainModule),
    typeof(AbpAccountApplicationModule),
    typeof(vNext框架介绍_ASPNETCoreApplicationApplicationContractsModule),
    typeof(AbpIdentityApplicationModule),
    typeof(AbpPermissionManagementApplicationModule),
    typeof(AbpTenantManagementApplicationModule),
    typeof(AbpFeatureManagementApplicationModule),
    typeof(AbpSettingManagementApplicationModule)
    )]
public class vNext框架介绍_ASPNETCoreApplicationApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<vNext框架介绍_ASPNETCoreApplicationApplicationModule>();
        });
    }
}
