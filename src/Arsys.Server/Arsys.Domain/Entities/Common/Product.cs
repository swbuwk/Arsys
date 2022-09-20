using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Arsys.Domain.Entities.Common;

public class Product
{
    [Key]
    public Guid Id { get; set; }

    [ForeignKey("Category")]
    public Guid CategoryId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string ImageUrl { get; set; }

    public decimal Price { get;  set; }
    
}
