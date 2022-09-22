using Arsys.DAL.Data.Repositories.Сommon.Interfaces;
using Arsys.Domain.Entities.Common;

namespace Arsys.DAL.Data.Repositories.Сommon.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly AppDbContext _appDbContext;
    private readonly IProductRepository _productRepository;
    public CategoryRepository(AppDbContext context, IProductRepository productRepository)
    {
        _appDbContext = context;
        _productRepository = productRepository;
    }
    public async Task<Category> GetCategoryByNameAsync(string name) => 
        await _appDbContext.Categories.FirstOrDefaultAsync(c => c.Name.Equals(name));

    public async Task<Category> GetCategoryByIdAsync(Guid categoryId)
        => await _appDbContext.Categories.FindAsync(new object[] {categoryId});       
}