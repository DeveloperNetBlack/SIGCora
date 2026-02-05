using SIGCora.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIGCora.DomainService.IRepositories.ICategoryRepositories
{
    public interface ICategoryUpdateRepository
    {
        Task<int> UpdateAsync(Category Model, CancellationToken CancellationToken);
    }
}
