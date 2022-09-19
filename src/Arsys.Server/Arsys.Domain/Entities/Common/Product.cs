namespace Arsys.Domain.Entities.Common;

public class Product
{
    public Guid Id { get; protected set; }

    public Guid CategoryId { get; protected set; }

    public string Name { get; protected set; }

    public string Description { get; protected set; }

    public string ImageUrl { get; protected set; }

    public decimal Price { get; protected set; }
}
