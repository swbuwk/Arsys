using Arsys.Domain.Entities.Common;

namespace Arsys.API.Application.MediatR.Supplies.Commands.RegisterSupply
{
    public class RegisterSupplyCommand : IRequest<Guid> 
    {
        //что необходимо для регистрации поставки                
        //public Guid EmployeeId { get; set; }
        public DateTime SupplyDate { get; set; }
        public bool IsComplete { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
