using Arsys.API.DTOs.CashDesk.ProductsDto;

namespace Arsys.API.Application.MediatR.Products.Queries.GetProductList;

public class GetProductListQuery : IRequest<ProductListDto>
{
    public Guid CategoryId { get; set; }
}