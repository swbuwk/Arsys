using Arsys.DAL.Data.Repositories.CashDesk.Interfaces;
using Arsys.Domain.Entities.CashDesk;

namespace Arsys.DAL.Data.Repositories.CashDesk.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly AppDbContext _appDbContext;
    public OrderRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    
    public async Task CreateOrderAsync(Order order)
    {
        order.OrderDate = DateTime.Now;              
        _appDbContext.AttachRange(order.Items.Select(i => i.Product));                        
        
        await _appDbContext.Orders.AddAsync(order);
        await SaveAsync();
    }
    private async Task SaveAsync() => await _appDbContext.SaveChangesAsync();     
}