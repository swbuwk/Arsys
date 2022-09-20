using Arsys.Domain.Entities.Storage;

namespace Arsys.DAL.Data.Repositories.Storage.Interfaces
{
    public interface ISupplyRepository
    {
        Task<IEnumerable<Supply>> GetAllSuppliesAsync();
        Task<Supply> GetSupplyByIdAsync(int id);
        
        Task RegisterSupplyAsync(Supply supply);
        Task DeleteSupplyAsync(int id);
        Task UpdateSupplyAsync(Supply supply);
    }
}
