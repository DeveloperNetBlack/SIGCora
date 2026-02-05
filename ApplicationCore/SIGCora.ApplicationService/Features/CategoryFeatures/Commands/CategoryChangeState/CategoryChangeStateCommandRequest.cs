using MediatR;
using SIGCora.DomainModel.Enum;
using SIGCora.Infrastructure.CrossCutting.Wrappers;

namespace SIGCora.ApplicationService.Features.CategoryFeatures.Commands.CategoryChangeState
{
    public record struct CategoryChangeStateCommandRequest
    (
        int CategoryId,
        StateEnum StateId
    ) : IRequest<MsgResponse<object?>>;
}
