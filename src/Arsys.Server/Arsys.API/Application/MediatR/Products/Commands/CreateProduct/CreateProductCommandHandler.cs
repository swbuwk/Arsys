using Arsys.DAL.Data.Repositories.Сommon.Interfaces;
using Arsys.Domain.Entities.Common;

namespace Arsys.API.Application.MediatR.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
    {
        private readonly IProductRepository _productRepository;
        public CreateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        
        public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                CategoryId = request.CategoryId,
                Description = request.Description,
                ImageUrl = request.ImageUrl,
                Price = request.Price
            };
            await _productRepository.CreateProductAsync(product);
            return product.Id;
        }
    }
}
