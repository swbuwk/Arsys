using Arsys.DAL.Data.Repositories.Сommon.Interfaces;
using Arsys.DAL.Exceptions;
using Arsys.Domain.Entities.Common;

namespace Arsys.DAL.Data.Repositories.Сommon.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _appDbContext;
    public ProductRepository(AppDbContext context)
    {
        _appDbContext = context;
    }

    public IQueryable<Product> GetProductsByCategoryIdAsync(Guid categoryId) =>
        _appDbContext.Products.Where(p => p.CategoryId.Equals(categoryId));
                      
    public async Task<Product> GetProductByIdAsync(Guid id)
    {
        var product = await _appDbContext.Products.FindAsync(new object[] { id }) 
                                ?? throw new NotFoundException(nameof(Product), id);
        return product;
    }
        
       
    public async Task CreateProductAsync(Product product)
    {
        await _appDbContext.AddAsync(product);
        await SaveAsync();
    }

    public async Task DeleteProductAsync(Guid id)
    {
        var product = await _appDbContext.Products.FindAsync(new object[] { id })
                               ?? throw new NotFoundException(nameof(Product), id);
        _appDbContext.Products.Remove(product);
        await SaveAsync();
    }

    public async Task UpdateProductAsync(Product product)
    {        
        _appDbContext.Products.Update(product);
        await SaveAsync();
    }

    private async Task SaveAsync() => await _appDbContext.SaveChangesAsync();     
}