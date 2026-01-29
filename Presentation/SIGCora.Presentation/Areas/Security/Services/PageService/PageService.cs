using SIGCora.Presentation.Helpers;
using SIGCora.Presentation.Areas.Security.Models.Page;
using SIGCora.Presentation.Services;

namespace SIGCora.Presentation.Areas.Security.Services.PageService
{
    public class PageService : IPageService
    {
        private readonly IApiService ApiService;
        private readonly string Controller = "Page";

        public PageService(IApiServiceFactory ApiServiceFactory)
        {
            this.ApiService = ApiServiceFactory.Create(ConstantsHelper.HttpClientNames.ApiCommerce360);
        }

        public async Task<ApiResponse<List<PageListResponseModel>>> PageList()
        {
           return await ApiService.GetAsync<ApiResponse<List<PageListResponseModel>>>($"{Controller}/PageList");
        }
    }
}
