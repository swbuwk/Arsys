using Arsys.DAL.Data.Repositories.CashDesk.Interfaces;

namespace Arsys.API.Application.MediatR.CashDesk.ShopCart.Commands.ClearShopCart;

public class ClearShopCartCommandHandler : IRequestHandler<ClearShopCartCommand>
{
    private readonly IShopCartRepository _shopCartRepository;

    public ClearShopCartCommandHandler(IShopCartRepository shopCartRepository)
    {
        _shopCartRepository = shopCartRepository; 
    }

    public async Task<Unit> Handle(ClearShopCartCommand request, CancellationToken cancellationToken)
    {
        await _shopCartRepository.Clear();
        return Unit.Value;
    }
}