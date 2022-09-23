namespace Arsys.API.Application.MediatR.Products.Commands.DeleteProduct
{
    public class DeleteProductCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
