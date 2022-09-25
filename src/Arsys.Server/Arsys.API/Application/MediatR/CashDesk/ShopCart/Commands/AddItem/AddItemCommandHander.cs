using Arsys.DAL.Data.Repositories.CashDesk.Interfaces;
using Arsys.DAL.Data.Repositories.Сommon.Interfaces;

namespace Arsys.API.Application.MediatR.CashDesk.ShopCart.Commands.AddItem;

public class AddItemCommandHandler : IRequestHandler<AddItemCommand>
{
   private readonly IShopCartRepository _shopCartRepository;
   private readonly IProductRepository _productRepository;

   public AddItemCommandHandler(IShopCartRepository shopCartRepository, IProductRepository productRepository)
   {
      _shopCartRepository = shopCartRepository;
      _productRepository = productRepository;
   }

   public async Task<Unit> Handle(AddItemCommand request, CancellationToken cancellationToken)
   {
      var product = await _productRepository.GetProductByIdAsync(request.ProductId);
      await _shopCartRepository.AddItem(product, request.Quantity);
      return Unit.Value;
   }
}
