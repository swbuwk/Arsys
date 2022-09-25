
namespace Arsys.API.Application.MediatR.CashDesk.ShopCart.Commands.AddItem;

public class AddItemCommand : IRequest
{
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
}