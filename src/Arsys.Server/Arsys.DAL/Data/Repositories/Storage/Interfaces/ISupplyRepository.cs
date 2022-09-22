using Arsys.Domain.Entities.Storage;

namespace Arsys.DAL.Data.Repositories.Storage.Interfaces
{
    public interface ISupplyRepository
    {
        IQueryable<Supply> Supplies { get; }

        Task<IEnumerable<Supply>> GetAllSuppliesAsync();
        Task<Supply> GetSupplyByIdAsync(Guid id, CancellationToken cancellationToken);
        
        Task RegisterSupplyAsync(Supply supply, CancellationToken cancellationToken);
        Task DeleteSupplyAsync(Guid id, CancellationToken cancellationToken);
        Task UpdateSupplyAsync(Guid id, CancellationToken cancellationToken);
    }
}
