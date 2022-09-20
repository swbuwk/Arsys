using Arsys.Domain.Entities.Common;

namespace Arsys.DAL.Data.Interfaces;

public interface ICategoryRepository
{
    Task<Category> GetCategoryByNameAsync(string name);
}