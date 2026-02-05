using SIGCora.DomainModel.Model;

namespace SIGCora.DomainService.IRepositories.ICategoryRepositories
{
    public interface ICategoryCreateRepository
    {
        Task<int> CreateAsync(Category Model, CancellationToken CancellationToken);
    }
}
