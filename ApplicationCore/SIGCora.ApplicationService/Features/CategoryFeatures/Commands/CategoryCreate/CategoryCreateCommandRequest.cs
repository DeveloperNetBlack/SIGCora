using MediatR;
using SIGCora.DomainModel.Enum;
using SIGCora.Infrastructure.CrossCutting.Wrappers;

namespace SIGCora.ApplicationService.Features.CategoryFeatures.Commands.CategoryCreate
{
    public record struct CategoryCreateCommandRequest
     (
        string CategoryCode,
        string CategoryName,
        StateEnum StateId
     ) : IRequest<MsgResponse<object>>;
}
