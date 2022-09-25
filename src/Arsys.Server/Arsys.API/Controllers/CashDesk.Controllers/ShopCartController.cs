using Arsys.API.Application.MediatR.CashDesk.ShopCart.Commands.AddItem;
using Arsys.API.Application.MediatR.CashDesk.ShopCart.Commands.ClearShopCart;
using Arsys.API.Application.MediatR.CashDesk.ShopCart.Commands.DeleteItem;
using Arsys.API.Application.MediatR.CashDesk.ShopCart.Queries.GetShopCart;
using Arsys.API.DTOs.CashDesk.ShopCartDto;
using Arsys.Domain.Entities.Common;

namespace Arsys.API.Controllers.CashDesk.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ShopCartController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    public ShopCartController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("AddItem")]
    public async Task<IActionResult> AddItem([FromBody] AddItemDto addItemDto) => 
        Ok(await _mediator.Send(
            new AddItemCommand(){
                ProductId = addItemDto.ProductId,
                Quantity = addItemDto.Quantity}));
    
    
    [HttpPost("DeleteItem/{id}")]
    public async Task<IActionResult> DeleteItem(Guid id) =>
        Ok(await _mediator.Send(new DeleteItemCommand() {Id = id}));


    [HttpPost("Clear")]
    public async Task<IActionResult> ClearShopCart() =>
        Ok(await _mediator.Send(new ClearShopCartCommand()));


    [HttpGet("GetShopCart")]
    public async Task<IActionResult> GetShopCart() =>
        Ok(await _mediator.Send(new GetShopCartQuery()));
    
    
    

}