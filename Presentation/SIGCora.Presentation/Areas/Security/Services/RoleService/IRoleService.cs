using SIGCora.Presentation.Models;
using SIGCora.Presentation.Areas.Security.Models.Role;
using SIGCora.Presentation.Services;

namespace SIGCora.Presentation.Areas.Security.Services.RoleService
{
    public interface IRoleService
    {
        Task<ApiResponse<object?>> RoleCreate(RoleCreateUpdateRequestModel Request);
        Task<ApiResponse<object?>> RoleUpdate(RoleCreateUpdateRequestModel Request);
        Task<ApiResponse<object?>> RoleChangeState(RoleChangeStateRequestModel Request);
        Task<ApiResponse<RoleGetResponseModel?>> RoleGet(int RoleID);
        Task<ApiResponse<PaginationResultModel<RolePaginationResponseModel>>> RolePagination(RolePaginationRequestModel Request);   
    }
}