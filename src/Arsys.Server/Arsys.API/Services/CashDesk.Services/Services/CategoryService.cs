using Arsys.API.DTOs;
using Arsys.API.Services.CashDesk.Services.Interfaces;
using Arsys.DAL.Data.Interfaces;
using Arsys.Domain.Entities.Common;
using StackExchange.Redis;

namespace Arsys.API.Services.CashDesk.Services.Services;

public class CategoryService : ICategoryService
{
    private readonly IConnectionMultiplexer _multiplexer;
    private readonly ICategoryRepository _categoryRepository;
    private readonly IProductRepository _productRepository;
    
    public CategoryService(ICategoryRepository categoryRepository, IProductRepository productRepository, IConnectionMultiplexer multiplexer)
    {
        _categoryRepository = categoryRepository;
        _productRepository = productRepository;
        _multiplexer = multiplexer;
    }

    public async Task<ProductListViewModel> GetProducts(string category)
    {
        Category currentCategory = await _categoryRepository
            .GetCategoryByNameAsync(category);
        List<Product> products = await _productRepository
            .GetProductsByCategory(currentCategory.Id); ;

        var model = new ProductListViewModel {Products = products};
        return model;
    }
    public async  Task SetValue(string key, string value)
    {
        var db = _multiplexer.GetDatabase();
        await db.StringSetAsync(key, value);
    }
}