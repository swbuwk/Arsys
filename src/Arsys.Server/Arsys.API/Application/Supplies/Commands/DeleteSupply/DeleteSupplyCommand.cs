namespace Arsys.API.Application.Supplies.Commands.DeleteSupply
{
    public class DeleteSupplyCommand : IRequest
    {        
        public Guid EmployeeId { get; set; }
        public Guid Id { get; set; }
    }
}
