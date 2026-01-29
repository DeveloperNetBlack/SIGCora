using SIGCora.Presentation.Models.Auth;

namespace SIGCora.Presentation.Services.AuthService
{
    public interface IAuthService
    {
        Task<ApiResponse<AuthTokenResponseModel?>> SignIn(AuthLoginTokenRequestModel Request);
        Task<ApiResponse<AuthTokenResponseModel?>> Refresh(AuthRefreshTokenRequestModel Request);
    }
}