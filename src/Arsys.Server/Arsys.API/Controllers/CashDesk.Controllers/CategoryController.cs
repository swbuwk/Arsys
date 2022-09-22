using Arsys.API.Services.CashDesk.Services.Interfaces;
using Arsys.DAL.Data.Repositories.CashDesk.Interfaces;
using Arsys.Domain.Entities.Common;

namespace Arsys.API.Controllers.CashDesk.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoryController : ControllerBase
{
    private readonly IShopCartRepository _shopCartRepository;
    public CategoryController( IShopCartRepository shopCartRepository)
    {
        _shopCartRepository = shopCartRepository;
    }
    

    [HttpPost]
    public async Task<IActionResult> Redis(Product product, int qu)
    {
        await _shopCartRepository.AddItem(product, qu);
        return Ok();
    }


}