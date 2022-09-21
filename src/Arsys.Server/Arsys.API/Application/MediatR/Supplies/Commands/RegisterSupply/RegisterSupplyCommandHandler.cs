using Arsys.DAL.Data.Repositories.Storage.Interfaces;
using Arsys.Domain.Entities.Storage;

namespace Arsys.API.Application.MediatR.Supplies.Commands.RegisterSupply
{
    public class RegisterSupplyCommandHandler : IRequestHandler<RegisterSupplyCommand, Guid>
    {        
        private readonly ISupplyRepository _supplyRepository;
        public RegisterSupplyCommandHandler(ISupplyRepository supplyRepository)
        {            
            _supplyRepository = supplyRepository;
        }
        
        public async Task<Guid> Handle(RegisterSupplyCommand request, 
            CancellationToken cancellationToken)
        {
            var supply = new Supply()
            {
                Id = Guid.NewGuid(),
                //EmployeeId = request.EmployeeId,
                SupplyDate = request.SupplyDate,
                IsComplete = false,   
                Products = request.Products
            };

            await _supplyRepository.RegisterSupplyAsync(supply, cancellationToken);           
            return supply.Id;
        }
    }
}
