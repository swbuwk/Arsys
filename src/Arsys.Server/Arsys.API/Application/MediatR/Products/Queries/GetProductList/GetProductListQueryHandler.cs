using Arsys.API.DTOs.CashDesk;
using Arsys.API.DTOs.Storage.SuppliesDto;
using Arsys.DAL.Data.Repositories.Сommon.Interfaces;

namespace Arsys.API.Application.MediatR.Products.Queries.GetProductList;

public class GetProductListQueryHandler : IRequestHandler<GetProductListQuery, ProductListDto>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;


    public GetProductListQueryHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<ProductListDto> Handle(GetProductListQuery request, CancellationToken cancellationToken)
    {
        var products = await _productRepository.GetProductsByCategoryIdAsync(request.CategoryId);                                              
        return new ProductListDto() {Products = products};
    }
}
