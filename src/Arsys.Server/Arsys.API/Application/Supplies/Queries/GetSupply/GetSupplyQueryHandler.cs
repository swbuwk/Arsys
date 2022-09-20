using Arsys.API.DTOs.Storage;
using Arsys.DAL.Data.Repositories.Storage.Interfaces;

namespace Arsys.API.Application.Supplies.Queries.GetSupply
{
    public class GetSupplyQueryHandler : IRequestHandler<GetSupplyQuery, SupplyDto>
    {
        private readonly ISupplyRepository _supplyRepository;
        private readonly IMapper _mapper;
        public GetSupplyQueryHandler(ISupplyRepository supplyRepository, IMapper mapper)
        {
            _supplyRepository = supplyRepository;
            _mapper = mapper;
        }

        public async Task<SupplyDto> Handle(GetSupplyQuery request,
            CancellationToken cancellationToken)
        {
            var supply = await _supplyRepository.GetSupplyByIdAsync(request.Id, request.EmployeeId, cancellationToken);
            return _mapper.Map<SupplyDto>(supply);
        }
    }
}
