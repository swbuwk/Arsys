namespace Arsys.Domain.Entities.Common;

public class Category
{
    public Guid Id { get; protected set; }

    public string Name { get; protected set; }

    public List<Product> Products { get; protected set; }
}
