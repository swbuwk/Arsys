using Arsys.API.DTOs.Storage;
using Arsys.DAL.Data.Repositories.Storage.Interfaces;
using AutoMapper.QueryableExtensions;

namespace Arsys.API.Application.Supplies.Queries.GetListSupply
{
    public class GetSupplyListQueryHandler
        : IRequestHandler<GetSupplyListQuery, SupplyListDto>
    {
        private readonly ISupplyRepository _supplyRepository;
        private readonly IMapper _mapper;
        
        public GetSupplyListQueryHandler(ISupplyRepository supplyRepository, IMapper mapper)
        {
            _supplyRepository = supplyRepository;
            _mapper = mapper;            
        }

        public async Task<SupplyListDto> Handle(GetSupplyListQuery request, CancellationToken cancellationToken)
        {
            var suppliesQuery = await _supplyRepository.Supplies
                                                       .Where(supply => supply.EmployeeId == request.EmployeeId)
                                                       .ProjectTo<SupplyLookupDto>(_mapper.ConfigurationProvider)
                                                       .ToListAsync(cancellationToken);
            
            return new SupplyListDto { Supplies = suppliesQuery };                                                       
        }
    }
}
