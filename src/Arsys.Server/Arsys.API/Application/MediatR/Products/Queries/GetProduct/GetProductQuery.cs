using Arsys.API.DTOs.CashDesk.ProductsDto;

namespace Arsys.API.Application.MediatR.Products.Queries.GetProduct
{
    public class GetProductQuery : IRequest<ProductDto>
    {
        public Guid Id { get; set; }
    }
}
