using Arsys.DAL.Data.Repositories.Сommon.Interfaces;

namespace Arsys.API.Application.MediatR.Products.Commands.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly IProductRepository _productRepository;
        public UpdateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {            
            var product = await _productRepository.GetProductByIdAsync(request.Id);
            await _productRepository.UpdateProductAsync(product);
            return Unit.Value;
        }
    }
}
