using Arsys.API.Application.MediatR.CashDesk.Order.Queires.GetOrderQuery;
using Arsys.API.DTOs.CashDesk.OrderDto;
using Arsys.DAL.Data.Repositories.CashDesk.Interfaces;

namespace Arsys.API.Application.MediatR.CashDesk.Order.Commands.CheckoutOrder;

public class CheckoutOrderCommandHandler : IRequestHandler<CheckoutOrderCommand>
{
    private readonly IMapper _mapper;
    private readonly IShopCartRepository _shopCartRepository;
    private readonly IOrderRepository _orderRepository;

    public CheckoutOrderCommandHandler(IMapper mapper, IShopCartRepository shopCartRepository, IOrderRepository orderRepository)
    {
        _mapper = mapper;
        _shopCartRepository = shopCartRepository;
        _orderRepository = orderRepository;
    }

    public async Task<Unit> Handle(CheckoutOrderCommand command, CancellationToken cancellationToken)
    {
        var cart = await _shopCartRepository.GetCart();
        var order = _mapper.Map<Domain.Entities.CashDesk.Order>(command);
        order.Items = cart.ShopCartItems;
        await _orderRepository.CreateOrderAsync(order);
        return Unit.Value;
    }
}