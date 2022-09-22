using Arsys.API.DTOs.CashDesk;

namespace Arsys.API.Application.MediatR.Products.Queries.GetProductList;

public class GetProductListQuery : IRequest<ProductListDto>
{
    public Guid CategoryId { get; set; }
}