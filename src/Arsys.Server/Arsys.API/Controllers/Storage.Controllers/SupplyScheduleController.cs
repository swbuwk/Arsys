using Arsys.API.Application.MediatR.Supplies.Commands.RegisterSupply;
using Arsys.API.Application.MediatR.Supplies.Queries.GetSupply;
using Arsys.API.DTOs.Storage;

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
        public async Task<ActionResult<Guid>> Register(SupplyDto supplyDto)
        {
            var command = _mapper.Map<RegisterSupplyCommand>(supplyDto);            
            var noteId = await _mediator.Send(command);
            return Ok(noteId);
        }
    }
}
