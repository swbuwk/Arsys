using Arsys.Domain.Entities.CashDesk;

namespace Arsys.DAL.Data.Repositories.CashDesk.Interfaces;

public interface IOrderRepository
{
    Task CreateOrderAsync(Order order);
}