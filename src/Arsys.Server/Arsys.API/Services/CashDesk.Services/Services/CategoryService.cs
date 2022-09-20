using Arsys.API.DTOs;
using Arsys.API.Services.CashDesk.Services.Interfaces;
using Arsys.DAL.Data.Interfaces;
using Arsys.Domain.Entities.Common;

namespace Arsys.API.Services.CashDesk.Services.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IProductRepository _productRepository;
    
    public CategoryService(ICategoryRepository categoryRepository, IProductRepository productRepository)
    {
        _categoryRepository = categoryRepository;
        _productRepository = productRepository;
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
}