using MediatR;
using SIGCora.Infrastructure.CrossCutting.Wrappers;

namespace SIGCora.ApplicationService.Features.AuthFeatures.Queries.UserLogin
{
    public record struct UserLoginQueryRequest(string CompanyDocumentNumber, string UserName, string UserPassword) : IRequest<MsgResponse<object>>;
}
