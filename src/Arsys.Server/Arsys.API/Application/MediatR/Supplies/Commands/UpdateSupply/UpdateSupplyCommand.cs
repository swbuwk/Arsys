namespace Arsys.API.Application.MediatR.Supplies.Commands.UpdateSupply
{
    public class UpdateSupplyCommand : IRequest
    {
        //public Guid EmployeeId { get; set; }
        public Guid Id { get; set; }        
    }
}
