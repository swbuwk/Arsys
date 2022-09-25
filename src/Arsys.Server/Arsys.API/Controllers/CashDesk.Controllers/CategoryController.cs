using Arsys.API.Application.MediatR.Products.Commands.CreateProduct;
using Arsys.API.Application.MediatR.Products.Queries.GetProductList;
using Arsys.API.DTOs.CashDesk.ProductsDto;
using Arsys.Domain.Entities.Common;

namespace Arsys.API.Controllers.CashDesk.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoryController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    public CategoryController(IMediator mediator, IMapper mapper)
    {
        //_shopCartRepository = shopCartRepository;
        _mediator = mediator;
        _mapper = mapper;
    }


    [HttpPost]
    public async Task<IActionResult> CreateProduct([FromBody] CreateProductDto dto) =>
        Ok(await _mediator.Send(_mapper.Map<CreateProductCommand>(dto)));
    
    /*[HttpGet]
    public async Task<IActionResult> GetList(Guid categoryId) => 
        Ok(_mediator.Send(_mapper.Map<ProductListDto>());Application*/
    


}