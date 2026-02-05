using MediatR;
using SIGCora.DomainModel.Dtos.Category;
using SIGCora.Infrastructure.CrossCutting.Wrappers;

namespace SIGCora.ApplicationService.Features.CategoryFeatures.Queries.CategoryGet
{
    public record struct CategoryGetQueryRequest(
       int CategoryId
    ) : IRequest<MsgResponse<CategoryGetResponseDto?>>;
}
