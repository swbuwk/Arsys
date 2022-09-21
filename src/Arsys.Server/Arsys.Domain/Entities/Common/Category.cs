namespace Arsys.Domain.Entities.Common;

public class Category
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public IEnumerable<Product> Products { get; set; }
}
