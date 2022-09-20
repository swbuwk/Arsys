using Arsys.DAL.Data.Repositories.Storage.Interfaces;
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
        
        public async Task<IEnumerable<Supply>> GetAllSuppliesAsync() =>       
            await _db.Supplies.Include(s => s.Products).ToListAsync();
        

        public async Task<Supply> GetSupplyByIdAsync(int id) =>
            await _db.Supplies.FindAsync(new object[] {id});
       
        public async Task RegisterSupplyAsync(Supply supply)
        {
            await _db.Supplies.AddAsync(supply);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteSupplyAsync(int id)
        {
            var supply = await _db.Supplies.FindAsync(new object[] { id });
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
