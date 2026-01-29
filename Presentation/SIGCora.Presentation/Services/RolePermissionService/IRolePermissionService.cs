using SIGCora.Presentation.Models.RolePermission;
using SIGCora.Presentation.Services;

namespace SIGCora.Presentation.Services.RolePermissionService
{
    public interface IRolePermissionService
    {
        Task<ApiResponse<List<RolePermissionListResponseModel>>> RolePermissionList(RolePermissionListRequestModel Request);
    }
}