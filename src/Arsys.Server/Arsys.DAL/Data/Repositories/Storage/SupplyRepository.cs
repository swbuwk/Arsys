using Arsys.DAL.Data.Repositories.Storage.Interfaces;
using Arsys.DAL.Exceptions;
using Arsys.Domain.Entities.Storage;
using Microsoft.EntityFrameworkCore;

namespace Arsys.DAL.Data.Repositories.Storage
{
    public class SupplyRepository : ISupplyRepository
    {               
        private readonly AppDbContext _db;
        
        public SupplyRepository(AppDbContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public IQueryable<Supply> Supplies => _db.Supplies;

        public async Task<IEnumerable<Supply>> GetAllSuppliesAsync() =>       
            await _db.Supplies.Include(s => s.Products).ToListAsync();
        

        public async Task<Supply> GetSupplyByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var supply = await _db.Supplies.FindAsync(new object[] { id }, cancellationToken);
            if (supply is null) //employeeId != supply.EmployeeId
                throw new NotFoundException(nameof(Supply), id);
            return supply;
        }
            
               
        public async Task RegisterSupplyAsync(Supply supply, CancellationToken cancellationToken)
        {
            await _db.Supplies.AddAsync(supply);
            await _db.SaveChangesAsync(cancellationToken);
        }
        
        public async Task DeleteSupplyAsync(Guid id, CancellationToken cancellationToken)
        {
            var supply = await _db.Supplies.FindAsync(new object[] { id });                        
            if (supply is null)
                throw new NotFoundException(nameof(Supply), id);            
            _db.Supplies.Remove(supply);
            await _db.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateSupplyAsync(Guid id, CancellationToken cancellationToken)
        {
            var supply = await _db.Supplies.FindAsync(new object[] { id });
            if (supply is null)
                throw new NotFoundException(nameof(Supply), id);            
            _db.Supplies.Update(supply);
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}
