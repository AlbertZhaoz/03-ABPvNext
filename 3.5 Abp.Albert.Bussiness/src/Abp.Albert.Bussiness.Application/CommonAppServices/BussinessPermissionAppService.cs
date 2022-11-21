using System;
using System.Threading.Tasks;
using Abp.Albert.Bussiness.CommonAppServices;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.PermissionManagement;

namespace Abp.Albert.Bussiness.CommonAppServices
{
    // 这是数据库默认的种子数据提供的权限，只有 admin 角色有权限
    [Authorize("AbpIdentity.Users.ManagePermissions")]
    public class BussinessPermissionAppService:BussinessAppService, ISelfBussinessPermission
    {
        // 依赖注入 PermissionManager，用来授予权限（通过 Role or Admin)
        private readonly IPermissionManager _permissionManager;

        public BussinessPermissionAppService(IPermissionManager permissionManager)
        {
            _permissionManager = permissionManager;
        }

        public async Task AddRolePermissionAsync(string roleName, string permission)
        {
            await _permissionManager
                .SetForRoleAsync(roleName, permission, true);
        }

        public async Task AddUserPermissionAsync(Guid userId, string permission)
        {
            await _permissionManager
                .SetForUserAsync(userId, permission, true);
        }
    }
}
