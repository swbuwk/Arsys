using Arsys.DAL.Data.Repositories.Storage.Interfaces;
using Arsys.Domain.Entities.Storage;

namespace Arsys.API.Application.MediatR.Supplies.Commands.UpdateSupply
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
            var supply = await _supplyRepository.GetSupplyByIdAsync(request.Id); 
            await _supplyRepository.UpdateSupplyAsync(supply);                                  
            return Unit.Value;
        }
    }
}
