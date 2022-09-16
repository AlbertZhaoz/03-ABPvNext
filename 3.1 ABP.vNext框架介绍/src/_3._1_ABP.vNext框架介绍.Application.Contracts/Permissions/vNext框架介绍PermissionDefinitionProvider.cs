using _3._1_ABP.vNext框架介绍.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace _3._1_ABP.vNext框架介绍.Permissions;

public class vNext框架介绍PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(vNext框架介绍Permissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(vNext框架介绍Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<vNext框架介绍Resource>(name);
    }
}
