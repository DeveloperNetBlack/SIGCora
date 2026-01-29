using SIGCora.Presentation.Models;
using SIGCora.Presentation.Areas.Security.Models.Company;
using SIGCora.Presentation.Services;

namespace SIGCora.Presentation.Areas.Security.Services.CompanyService
{
    public interface ICompanyService
    {
        Task<ApiResponse<object?>> CompanyCreate(CompanyCreateUpdateRequestModel Request);
        Task<ApiResponse<object?>> CompanyUpdate(CompanyCreateUpdateRequestModel Request);
        Task<ApiResponse<object?>> CompanyChangeState(CompanyChangeStateRequestModel Request);
        Task<ApiResponse<CompanyGetResponseModel?>> CompanyGet(int CompanyID);
        Task<ApiResponse<PaginationResultModel<CompanyPaginationResponseModel>>> CompanyPagination(CompanyPaginationRequestModel Request);
        Task<ApiResponse<List<CompanyListResponseModel>>> CompanyList(int CompanyIDRegister);
    }
}
