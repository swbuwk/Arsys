using Arsys.Domain.Entities.CashDesk;
using Arsys.Domain.Entities.Common;

namespace Arsys.DAL.Data.Repositories.CashDesk.Interfaces;

public interface IShopCartRepository
{
    Task<ShopCart> GetCart();
    Task AddItem(Product item, int quantity);
    Task DeleteItem(Guid id);
    Task Clear();
}