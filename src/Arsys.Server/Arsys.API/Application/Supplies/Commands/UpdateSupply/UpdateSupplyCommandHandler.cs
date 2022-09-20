using Arsys.DAL.Data.Repositories.Storage.Interfaces;

namespace Arsys.API.Application.Supplies.Commands.UpdateSupply
{
    public class UpdateSupplyCommandHandler : IRequestHandler<UpdateSupplyCommand>
    {
        private readonly ISupplyRepository _supplyRepository;
        public UpdateSupplyCommandHandler(ISupplyRepository supplyRepository)
        {
            _supplyRepository = supplyRepository;
        }

        public async Task<Unit> Handle(UpdateSupplyCommand request, 
            CancellationToken cancellationToken)
        {
            await _supplyRepository.UpdateSupplyAsync(request.Id, request.EmployeeId, cancellationToken);            
            return Unit.Value;
        }
    }
}
