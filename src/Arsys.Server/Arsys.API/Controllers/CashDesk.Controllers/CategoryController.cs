using Arsys.API.Services.CashDesk.Services.Interfaces;
using Arsys.API.Services.RedisCacheControl.Service.Interfaces;
using Arsys.DAL.Data.Interfaces;
using Arsys.Domain.Entities.Common;
using StackExchange.Redis;

namespace Arsys.API.Controllers.CashDesk.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;
    private readonly IRedisCacheControlService _cache;
    public CategoryController(ICategoryService categoryService, IRedisCacheControlService cache)
    {
        _categoryService = categoryService;
        _cache = cache;
    }

    [HttpGet("GetProducts")]
    public async Task<IActionResult> GetProducts(string category) => 
        Ok(await _categoryService.GetProducts(category));
    
}