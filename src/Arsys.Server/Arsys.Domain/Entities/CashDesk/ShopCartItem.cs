using System.ComponentModel.DataAnnotations;
using Arsys.Domain.Entities.Common;

namespace Arsys.Domain.Entities.CashDesk;

public class ShopCartItem
{
    public int Id { get; set; }
    public int Quantity { get; set; }
    [Required]
    public Product Product { get; set; }    
}