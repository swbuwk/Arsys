using Arsys.DAL.Data.Repositories.CashDesk.Interfaces;
using Arsys.Domain.Entities.CashDesk;

namespace Arsys.API.Controllers.CashDesk.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{
    private readonly IShopCartRepository _shopCartRepository;
    private readonly IOrderRepository _orderRepository;
    public OrderController(IShopCartRepository shopCartRepository, IOrderRepository orderRepository)
    {
        _shopCartRepository = shopCartRepository;
        _orderRepository = orderRepository;
    }

    [HttpPost]
    public async Task<ActionResult> CreateOrder(Order order)
    {
        var cart = await _shopCartRepository.GetCart();
        order.Items = cart.ShopCartItems;
        await _orderRepository.CreateOrderAsync(order);
        return Ok();
    }
}
