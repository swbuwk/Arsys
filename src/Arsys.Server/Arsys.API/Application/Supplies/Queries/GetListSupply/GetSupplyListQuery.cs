using Arsys.API.DTOs.Storage;

namespace Arsys.API.Application.Supplies.Queries.GetListSupply
{
    public class GetSupplyListQuery : IRequest<SupplyListDto>
    {
        public Guid EmployeeId { get; set; }
    }
}
