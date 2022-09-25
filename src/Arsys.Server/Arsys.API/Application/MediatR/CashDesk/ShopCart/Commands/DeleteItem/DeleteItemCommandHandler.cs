using Arsys.API.Application.MediatR.CashDesk.ShopCart.Commands.ClearShopCart;
using Arsys.DAL.Data.Repositories.CashDesk.Interfaces;

namespace Arsys.API.Application.MediatR.CashDesk.ShopCart.Commands.DeleteItem;

public class DeleteItemCommandHandler : IRequestHandler<DeleteItemCommand>
{
    private readonly IShopCartRepository _shopCartRepository;

    public DeleteItemCommandHandler(IShopCartRepository shopCartRepository)
    {
        _shopCartRepository = shopCartRepository; 
    }

    public async Task<Unit> Handle(DeleteItemCommand request, CancellationToken cancellationToken)
    {
        await _shopCartRepository.DeleteItem(request.Id);
        return Unit.Value;
    }
}