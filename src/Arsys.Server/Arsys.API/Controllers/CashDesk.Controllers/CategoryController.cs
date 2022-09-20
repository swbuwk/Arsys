using Arsys.API.Services.CashDesk.Services.Interfaces;
using Arsys.DAL.Data.Interfaces;
using StackExchange.Redis;

namespace Arsys.API.Controllers.CashDesk.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;
    private readonly IConnectionMultiplexer _multiplexer;
    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet("GetProducts")]
    public async Task<IActionResult> GetProducts(string category) => 
        Ok(await _categoryService.GetProducts(category));

    [HttpPost("cache")]
    public async Task<IActionResult> Set(string key, string value)
    {
        await _categoryService.SetValue(key, value);
        return Ok();
    }
    
}