using Arsys.DAL.Data.Repositories.Storage.Interfaces;
using Arsys.DAL.Exceptions;
using Arsys.Domain.Entities.Storage;

namespace Arsys.DAL.Data.Repositories.Storage
{
    public class SupplyRepository : ISupplyRepository
    {               
        private readonly AppDbContext _db;
        
        public SupplyRepository(AppDbContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }
       
        public IQueryable<Supply> GetAllSuppliesAsync() =>       
            _db.Supplies.Include(s => s.Products);
        
        public async Task<Supply> GetSupplyByIdAsync(Guid id)
        {
            var supply = await _db.Supplies.FindAsync(new object[] { id });
            if (supply is null) //employeeId != supply.EmployeeId
                throw new NotFoundException(nameof(Supply), id);
            return supply;
        }
            
               
        public async Task RegisterSupplyAsync(Supply supply)
        {
            await _db.Supplies.AddAsync(supply);
            await _db.SaveChangesAsync();
        }
        
        public async Task DeleteSupplyAsync(Guid id)
        {
            var supply = await _db.Supplies.FindAsync(new object[] { id });                        
            if (supply is null)
                throw new NotFoundException(nameof(Supply), id);            
            _db.Supplies.Remove(supply);
            await _db.SaveChangesAsync();
        }

        public async Task UpdateSupplyAsync(Supply supply)
        {                                    
            _db.Supplies.Update(supply);
            await _db.SaveChangesAsync();
        }
    }
}
