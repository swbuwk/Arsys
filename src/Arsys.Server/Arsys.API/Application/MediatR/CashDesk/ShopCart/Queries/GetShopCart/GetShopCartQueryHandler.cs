using Arsys.API.DTOs.CashDesk.ShopCartDto;
using Arsys.DAL.Data.Repositories.CashDesk.Interfaces;

namespace Arsys.API.Application.MediatR.CashDesk.ShopCart.Queries.GetShopCart;

public class GetShopCartQueryHandler : IRequestHandler<ShopCart.Queries.GetShopCart.GetShopCartQuery, ShopCartDto>
{
    private readonly IShopCartRepository _shopCartRepository;
    private readonly IMapper _mapper;
    
    public GetShopCartQueryHandler(IShopCartRepository shopCartRepository, IMapper mapper)
    {
        _shopCartRepository = shopCartRepository;
        _mapper = mapper;
    }

    public async Task<ShopCartDto> Handle(GetShopCartQuery request, CancellationToken cancellationToken)
    {
        var cart = await _shopCartRepository.GetCart();
        return _mapper.Map<ShopCartDto>(cart);
    }

}