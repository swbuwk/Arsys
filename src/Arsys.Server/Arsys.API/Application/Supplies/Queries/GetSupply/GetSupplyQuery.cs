using Arsys.API.DTOs.Storage;

namespace Arsys.API.Application.Supplies.Queries.GetSupply
{
    public class GetSupplyQuery : IRequest<SupplyDto>
    {
        public Guid EmployeeId { get; set; }
        public Guid Id { get; set; }       
    }
}
