using SIGCora.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIGCora.DomainService.IRepositories.ICategoryRepositories
{
    public interface ICategoryValidateRepository
    {
        Task<string> ValidateAsync(Category Model, CancellationToken CancellationToken);
    }
}
