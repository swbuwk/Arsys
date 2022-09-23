namespace Arsys.API.Application.MediatR.Products.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<Guid>
    {                        
        public Guid CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }
    }
}
