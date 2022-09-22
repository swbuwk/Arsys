using Arsys.DAL.Data.Repositories.Сommon.Interfaces;
using Arsys.Domain.Entities.Common;

namespace Arsys.DAL.Data.Repositories.Сommon.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _appDbContext;
    public ProductRepository(AppDbContext context)
    {
        _appDbContext = context;
    }

    public async Task CreateProduct(Product product)
    {
        await _appDbContext.AddAsync(product);
        await SaveAsync();
    }
    public async Task<List<Product>> GetProductsByCategoryIdAsync(Guid categoryId) =>
        await _appDbContext.Products.Where(p => p.CategoryId.Equals(categoryId))
        .ToListAsync();

    private async Task SaveAsync() => await _appDbContext.SaveChangesAsync();     
}