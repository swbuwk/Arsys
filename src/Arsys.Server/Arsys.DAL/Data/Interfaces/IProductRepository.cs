using Arsys.Domain.Entities.Common;

namespace Arsys.DAL.Data.Interfaces;

public interface IProductRepository
{
    Task<List<Product>> GetProductsByCategory(Guid categoryId);
    Task CreateProduct(Product product);
}