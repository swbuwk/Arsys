namespace Arsys.API.Application.MediatR.CashDesk.ShopCart.Commands.DeleteItem;

public class DeleteItemCommand  : IRequest
{
    public Guid Id { get; set; }
}