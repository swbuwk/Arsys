using Arsys.Domain.Entities.Storage;

namespace Arsys.DAL.Data.Repositories.Storage.Interfaces
{
    public interface ISupplyRepository
    {
        IQueryable<Supply> GetAllSuppliesAsync();
        Task<Supply> GetSupplyByIdAsync(Guid id);
        
        Task RegisterSupplyAsync(Supply supply);
        Task DeleteSupplyAsync(Guid id);
        Task UpdateSupplyAsync(Supply supply);
    }
}
