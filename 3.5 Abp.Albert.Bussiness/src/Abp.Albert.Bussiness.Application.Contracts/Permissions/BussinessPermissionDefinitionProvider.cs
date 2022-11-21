using Abp.Albert.Bussiness.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Abp.Albert.Bussiness.Permissions;

public class BussinessPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BussinessPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BussinessPermissions.MyPermission1, L("Permission:MyPermission1"));
        // Product有一个默认的权限和一个子权限
        myGroup.AddPermission(BussinessPermissions.Product.Default)
            .AddChild(BussinessPermissions.Product.DefaultSelectByTitle);
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BussinessResource>(name);
    }
}
