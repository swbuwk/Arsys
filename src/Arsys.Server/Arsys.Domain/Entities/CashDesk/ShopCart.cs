using System.ComponentModel.DataAnnotations;
using Arsys.Domain.Entities.Common;

namespace Arsys.Domain.Entities.CashDesk;

public class ShopCart
{
    public Guid Id { get; set; }
    public List<ShopCartItem> ShopCartItems { get; set; } = new List<ShopCartItem>();
    
    public decimal ComputeCartPrice() =>
        ShopCartItems != null
            ? ShopCartItems.Sum(item => item.Quantity * item.Product.Price)
            : 0;
}