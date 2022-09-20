using Arsys.API.Services.CashDesk.Services.Interfaces;
using Arsys.DAL.Data.Interfaces;

namespace Arsys.API.Controllers.CashDesk.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;
    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet("GetProducts")]
    public async Task<IActionResult> GetProducts(string category) => 
        Ok(await _categoryService.GetProducts(category));
    
}