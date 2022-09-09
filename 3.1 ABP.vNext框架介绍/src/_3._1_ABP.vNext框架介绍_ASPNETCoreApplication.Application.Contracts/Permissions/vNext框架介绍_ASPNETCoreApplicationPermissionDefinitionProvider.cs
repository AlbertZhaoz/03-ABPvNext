using _3._1_ABP.vNext框架介绍_ASPNETCoreApplication.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace _3._1_ABP.vNext框架介绍_ASPNETCoreApplication.Permissions;

public class vNext框架介绍_ASPNETCoreApplicationPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(vNext框架介绍_ASPNETCoreApplicationPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(vNext框架介绍_ASPNETCoreApplicationPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<vNext框架介绍_ASPNETCoreApplicationResource>(name);
    }
}
