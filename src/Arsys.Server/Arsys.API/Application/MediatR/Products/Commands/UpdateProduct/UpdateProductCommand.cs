namespace Arsys.API.Application.MediatR.Products.Commands.UpdateProduct
{
    public class UpdateProductCommand : IRequest
    {
        public Guid Id { get; set; }
        
        public Guid CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }
    }
}
