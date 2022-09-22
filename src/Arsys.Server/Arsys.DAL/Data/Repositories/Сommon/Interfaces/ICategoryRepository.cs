using Arsys.Domain.Entities.Common;

namespace Arsys.DAL.Data.Repositories.Сommon.Interfaces;

public interface ICategoryRepository
{
    Task<Category> GetCategoryByNameAsync(string name);
    Task<Category> GetCategoryByIdAsync(Guid categoryId);    
}