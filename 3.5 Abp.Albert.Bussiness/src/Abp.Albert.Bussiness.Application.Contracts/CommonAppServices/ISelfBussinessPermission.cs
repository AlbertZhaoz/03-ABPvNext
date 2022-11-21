using System;
using System.Threading.Tasks;

namespace Abp.Albert.Bussiness.CommonAppServices
{
    public interface ISelfBussinessPermission
    {
        // 通过角色来授予权限
        public Task AddRolePermissionAsync(string roleName, string permission);

        // 通过用户来授予权限
        public Task AddUserPermissionAsync(Guid userId, string permission);
    }
}
