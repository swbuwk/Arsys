using Arsys.API.Application.Mappings;
using Arsys.API.Application.MediatR.CashDesk.Order.Commands.CheckoutOrder;
using Arsys.API.Application.MediatR.CashDesk.Order.Queires.GetOrderQuery;
using Arsys.API.DTOs.CashDesk.OrderDto;
using Arsys.DAL.Data.Repositories.CashDesk.Interfaces;
using Arsys.Domain.Entities.CashDesk;

namespace Arsys.API.Controllers.CashDesk.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{

    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    public OrderController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<ActionResult> CreateOrder([FromBody] OrderDto orderDto) =>
        Ok(await _mediator.Send(_mapper.Map<CheckoutOrderCommand>(orderDto)));
}
