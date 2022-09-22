using Arsys.API.Application.MediatR.Products.Queries.GetProductList;
using Arsys.DAL.Data.Repositories.CashDesk.Interfaces;
using Arsys.Domain.Entities.Common;

namespace Arsys.API.Controllers.CashDesk.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoryController : ControllerBase
{
    //private readonly IShopCartRepository _shopCartRepository;
    private readonly IMediator _mediator;
    
    public CategoryController(IMediator mediator)
    {
        //_shopCartRepository = shopCartRepository;
        _mediator = mediator;
    }
    
/*
    [HttpPost]
    public async Task<IActionResult> Redis(Product product, int qu)
    {
        await _shopCartRepository.AddItem(product, qu);
        return Ok();
    }*/

    [HttpGet]
    public async Task<IActionResult> GetList(Guid categoryId)
    {
        var query = new GetProductListQuery
        {
            CategoryId = categoryId
        };
        var dto = await _mediator.Send(query);
        return Ok(dto);
    }


}