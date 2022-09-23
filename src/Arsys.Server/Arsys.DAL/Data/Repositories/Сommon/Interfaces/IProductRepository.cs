using Arsys.Domain.Entities.Common;

namespace Arsys.DAL.Data.Repositories.Сommon.Interfaces;

public interface IProductRepository
{       
    IQueryable<Product> GetProductsByCategoryIdAsync(Guid categoryId);
    Task<Product> GetProductByIdAsync(Guid id);
    
    Task CreateProductAsync(Product product);
    Task DeleteProductAsync(Guid id);
    Task UpdateProductAsync(Product product);
}