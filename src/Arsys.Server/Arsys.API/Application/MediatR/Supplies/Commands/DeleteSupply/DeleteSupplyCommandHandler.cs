using Arsys.DAL.Data.Repositories.Storage.Interfaces;

namespace Arsys.API.Application.MediatR.Supplies.Commands.DeleteSupply
{
    public class DeleteSupplyCommandHandler : IRequestHandler<DeleteSupplyCommand>
    {
        private readonly ISupplyRepository _supplyRepository;
        public DeleteSupplyCommandHandler(ISupplyRepository supplyRepository)
        {
            _supplyRepository = supplyRepository;
        }

        public async Task<Unit> Handle(DeleteSupplyCommand request, CancellationToken cancellationToken)
        {
            await _supplyRepository.DeleteSupplyAsync(request.Id);
            return Unit.Value; //пустой ответ
        }
    }
}
