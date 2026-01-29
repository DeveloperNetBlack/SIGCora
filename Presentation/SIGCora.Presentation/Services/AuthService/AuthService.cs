using SIGCora.Presentation.Helpers;
using SIGCora.Presentation.Models.Auth;

namespace SIGCora.Presentation.Services.AuthService
{
    public class AuthService : IAuthService
    {
        private readonly IApiService ApiService;

        public AuthService(IApiServiceFactory ApiServiceFactory)
        {
            this.ApiService = ApiServiceFactory.Create(ConstantsHelper.HttpClientNames.ApiAuth360);
        } 

        public async Task<ApiResponse<AuthTokenResponseModel?>> SignIn(AuthLoginTokenRequestModel Request)
        {
            return await ApiService.PostAsync<AuthLoginTokenRequestModel, ApiResponse<AuthTokenResponseModel?>>("Auth/SignIn", Request);
        }

        public async Task<ApiResponse<AuthTokenResponseModel?>> Refresh(AuthRefreshTokenRequestModel Request)
        {
            return await ApiService.PostAsync<AuthRefreshTokenRequestModel, ApiResponse<AuthTokenResponseModel?>>("Auth/Refresh", Request);          
        }
    }
}