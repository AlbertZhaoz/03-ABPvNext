namespace Abp.Albert.Bussiness.Permissions;

public static class BussinessPermissions
{
    public const string GroupName = "Bussiness";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
    public static class Product
    {
        public const string Default = GroupName + ".Product";
        public const string DefaultSelectByTitle = Default + ".DefaultSelectByTitle";
    }
}
