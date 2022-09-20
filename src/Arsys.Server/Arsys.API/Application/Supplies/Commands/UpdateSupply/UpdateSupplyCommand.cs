namespace Arsys.API.Application.Supplies.Commands.UpdateSupply
{
    public class UpdateSupplyCommand : IRequest
    {
        public Guid EmployeeId { get; set; }
        public Guid Id { get; set; }        
    }
}
