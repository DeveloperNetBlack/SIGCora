using SIGCora.DomainModel.Dtos.User;

namespace SIGCora.DomainService.IRepositories.IUserRepositories
{
    public interface IUserLoginRepository
    {
        Task<UserLoginResponseDto> Get(UserLoginRequestDto UserCredentials);
    }
}
