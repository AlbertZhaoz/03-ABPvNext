using Localization.Resources.AbpUi;
using _3._1_ABP.vNext框架介绍_ASPNETCoreApplication.Localization;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

namespace _3._1_ABP.vNext框架介绍_ASPNETCoreApplication;

[DependsOn(
    typeof(vNext框架介绍_ASPNETCoreApplicationApplicationContractsModule),
    typeof(AbpAccountHttpApiModule),
    typeof(AbpIdentityHttpApiModule),
    typeof(AbpPermissionManagementHttpApiModule),
    typeof(AbpTenantManagementHttpApiModule),
    typeof(AbpFeatureManagementHttpApiModule),
    typeof(AbpSettingManagementHttpApiModule)
    )]
public class vNext框架介绍_ASPNETCoreApplicationHttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureLocalization();
    }

    private void ConfigureLocalization()
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<vNext框架介绍_ASPNETCoreApplicationResource>()
                .AddBaseTypes(
                    typeof(AbpUiResource)
                );
        });
    }
}
