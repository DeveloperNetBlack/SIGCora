using SIGCora.Presentation.Areas.Security.Models.Page;
using SIGCora.Presentation.Areas.Security.Models.PageCompany;
using SIGCora.Presentation.Services;

namespace SIGCora.Presentation.Areas.Security.Services.PageCompanyService
{
    public interface IPageCompanyService
    {
        Task<ApiResponse<object?>> PageCompanyDeleteCreate(PageCompanyDeleteCreateRequestModel Request);
        Task<ApiResponse<List<PageListResponseModel>>> PageCompanyList(int CompanyID);
    }
}