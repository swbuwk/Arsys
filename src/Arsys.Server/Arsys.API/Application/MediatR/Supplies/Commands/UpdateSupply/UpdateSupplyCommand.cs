using Arsys.Domain.Entities.Common;

namespace Arsys.API.Application.MediatR.Supplies.Commands.UpdateSupply
{
    public class UpdateSupplyCommand : IRequest
    {
        //public Guid EmployeeId { get; set; }
        public Guid Id { get; set; }
        public DateTime SupplyDate { get; set; }
        public bool IsComplete { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
