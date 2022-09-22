using Arsys.Domain.Entities.Common;

namespace Arsys.DAL.Data.Repositories.Сommon.Interfaces;

public interface IProductRepository
{
    Task<List<Product>> GetProductsByCategoryIdAsync(Guid categoryId);
    
    Task CreateProduct(Product product);
}