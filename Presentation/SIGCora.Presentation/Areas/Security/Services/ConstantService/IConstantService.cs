using SIGCora.Presentation.Areas.Security.Models.Constant;
using SIGCora.Presentation.Services;

namespace SIGCora.Presentation.Areas.Security.Services.ConstantService
{
    public interface IConstantService
    {
        Task<ApiResponse<List<ConstantListResponseModel>>> ConstantList(string ConstantClassConcat);       
    }
}