using MediatR;

namespace SIGCora.ApplicationService.Features.AuthFeatures.Queries.UserLogin
{
    internal class UserLoginQueryHandler : IRequestHandler<UserLoginQueryRequest, string>
    {
        public async Task<string> Handle(UserLoginQueryRequest request, CancellationToken cancellationToken)
        {
            var response = UserList().FirstOrDefault(u =>
                u.CompanyDocumentNumber == request.CompanyDocumentNumber &&
                u.UserName == request.UserName &&
                u.UserPassword == request.UserPassword);

            if (response is null) return "Usuario o contraseña incorrecta.";

            return $"Bienvenido {response.UserName}";
        }

        private List<Commons.UserResponseDto> UserList()
        {
            return new List<Commons.UserResponseDto>
            {
                new Commons.UserResponseDto
                {
                    UserId = 1,
                    CompanyId = 1,
                    CompanyDocumentNumber = "19",
                    UserName = "admin",
                    UserPassword = "admin123"
                },
                new Commons.UserResponseDto
                {
                    UserId = 2,
                    CompanyId = 1,
                    CompanyDocumentNumber = "27",
                    UserName = "user",
                    UserPassword = "user123"
                }
            };
        }
    }
}
