using System.ComponentModel.DataAnnotations;

namespace Arsys.Domain.Entities.Common;

public class Category
{
    [Key]
    public Guid Id { get; set; }

    public string Name { get; set; }
    
    public string ImageUrl { get; set; }

    public List<Product> Products { get; set; }
}
