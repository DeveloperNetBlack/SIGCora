using SIGCora.Presentation.Areas.Security.Models.Page;
using SIGCora.Presentation.Services;

namespace SIGCora.Presentation.Areas.Security.Services.PageService
{
    public interface IPageService
    {
        Task<ApiResponse<List<PageListResponseModel>>> PageList();
    }
}
