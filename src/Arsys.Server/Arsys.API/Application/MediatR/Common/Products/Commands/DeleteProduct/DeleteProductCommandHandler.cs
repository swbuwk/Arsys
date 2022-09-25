using Arsys.API.Application.MediatR.Products.Commands.DeleteProduct;
using Arsys.DAL.Data.Repositories.Сommon.Interfaces;

namespace Arsys.API.Application.MediatR.Common.Products.Commands.DeleteProduct
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
    {
        private readonly IProductRepository _productRepository;
        public DeleteProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            await _productRepository.DeleteProductAsync(request.Id);
            return Unit.Value;
        }
    }
}
