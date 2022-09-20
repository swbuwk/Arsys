using Arsys.DAL.Data.Interfaces;
using Arsys.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace Arsys.DAL.Data.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly AppDbContext _appDbContext;
    public CategoryRepository(AppDbContext context)
    {
        _appDbContext = context;
    }
    public async Task<Category> GetCategoryByNameAsync(string name) => 
        await _appDbContext.Categories.FirstOrDefaultAsync(c => c.Name.Equals(name));
}