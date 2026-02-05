using SIGCora.DomainModel.Dtos.Category;

namespace SIGCora.DomainService.IRepositories.ICategoryRepositories
{
    public interface ICategoryGetRepository
    {
        Task<CategoryGetResponseDto?> GetAsync(int CategoryId, CancellationToken CancellationToken);
    }
}
