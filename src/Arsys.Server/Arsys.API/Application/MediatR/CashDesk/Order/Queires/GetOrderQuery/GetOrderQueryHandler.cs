using Arsys.API.Application.Mappings;
using Arsys.API.DTOs.CashDesk.OrderDto;
using Arsys.DAL.Data.Repositories.CashDesk.Interfaces;

namespace Arsys.API.Application.MediatR.CashDesk.Order.Queires.GetOrderQuery;

public class GetOrderQueryHandler : IRequestHandler<GetOrderQuery, OrderDto>
{
    private readonly IMapper _mapper;
    private readonly IShopCartRepository _shopCartRepository;

    public GetOrderQueryHandler(IMapper mapper, IShopCartRepository shopCartRepository)
    {
        _mapper = mapper;
        _shopCartRepository = shopCartRepository;
    }

    public async Task<OrderDto> Handle(GetOrderQuery query, CancellationToken cancellationToken)
    {
        var cart = await _shopCartRepository.GetCart();
        return _mapper.Map<OrderDto>(cart);
    }
}