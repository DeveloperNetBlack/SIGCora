using MediatR;
using SIGCora.DomainModel.Enum;
using SIGCora.Infrastructure.CrossCutting.Wrappers;

namespace SIGCora.ApplicationService.Features.CategoryFeatures.Commands.CategoryUpdate
{
    public record struct CategoryUpdateCommandRequest
    (
        int CategoryId,
        string CategoryName,
        StateEnum StateId
    ) : IRequest<MsgResponse<object?>>;
}
