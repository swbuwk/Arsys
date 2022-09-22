using Arsys.API.DTOs.CashDesk;
using Arsys.DAL.Data.Repositories.Сommon.Interfaces;
using AutoMapper;

namespace Arsys.API.Application.MediarR.Products.Queries.GetProductList;

public class GetProductListQueryHandler : IReqestHandler<GetProductListQuery, ProductListDto>
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
