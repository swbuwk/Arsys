namespace Arsys.API.Application.MediatR.Supplies.Commands.DeleteSupply
{
    public class DeleteSupplyCommand : IRequest
    {        
        //public Guid EmployeeId { get; set; }
        public Guid Id { get; set; }
    }
}
