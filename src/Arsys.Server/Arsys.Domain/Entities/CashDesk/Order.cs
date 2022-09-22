namespace Arsys.Domain.Entities.CashDesk;

public class Order
{
    public Guid Id { get; set; }
    
    public bool Shipped { get; set; }
    
    public string CustomerName { get; set; }
    
    public string CustomerSurname { get; set; }
    
    public string Adress { get; set; }
    
    public string Email { get; set; }
    public DateTime OrderDate { get; set; }
    public ICollection<ShopCartItem> Items { get; set; }
}