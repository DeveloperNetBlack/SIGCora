using SIGCora.DomainModel.Model;

namespace SIGCora.DomainService.IRepositories.ICategoryRepositories
{
    public interface  ICategoryChangeStateRepository
    {
        Task<int> ChangeStateAsync(Category Model, CancellationToken CancellationToken);
    }
}
