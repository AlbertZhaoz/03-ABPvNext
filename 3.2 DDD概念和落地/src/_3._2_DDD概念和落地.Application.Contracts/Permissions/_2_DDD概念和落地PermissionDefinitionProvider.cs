using _3._2_DDD概念和落地.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace _3._2_DDD概念和落地.Permissions;

public class _2_DDD概念和落地PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(_2_DDD概念和落地Permissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(_2_DDD概念和落地Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<_2_DDD概念和落地Resource>(name);
    }
}
