using Arsys.API.Application.MediatR.Supplies.Commands.DeleteSupply;
using Arsys.API.Application.MediatR.Supplies.Commands.RegisterSupply;
using Arsys.API.Application.MediatR.Supplies.Queries.GetListSupply;
using Arsys.API.Application.MediatR.Supplies.Queries.GetSupply;
using Arsys.API.DTOs.Storage.SuppliesDto;

namespace Arsys.API.Controllers.Storage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplyScheduleController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public SupplyScheduleController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<SupplyListDto>> GetAll()
        {
            var query = new GetSupplyListQuery();            
            var vm = await _mediator.Send(query);
            return Ok(vm);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SupplyDto>> Get(Guid id)
        {
            var query = new GetSupplyQuery
            {
                Id = id
            };
            var dto = await _mediator.Send(query);
            return Ok(dto);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Register([FromBody] RegisterSupplyDto regSupplyDto)
        {
            var command = _mapper.Map<RegisterSupplyCommand>(regSupplyDto);
            var supplyId = await _mediator.Send(command);
            return Ok(supplyId);
        }

        [HttpPut]
        public async Task<ActionResult<Guid>> Update([FromBody] UpdateSupplyDto updSupplyDto)
        {
            var command = _mapper.Map<UpdateSupplyDto>(updSupplyDto);
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var command = new DeleteSupplyCommand
            {
                Id = id,                
            };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
