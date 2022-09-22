using Arsys.DAL.Data.Extensions;
using Arsys.DAL.Data.Repositories.CashDesk.Interfaces;
using Arsys.Domain.Entities.CashDesk;
using Arsys.Domain.Entities.Common;
using StackExchange.Redis;

namespace Arsys.DAL.Data.Repositories.CashDesk.Repositories;



public class ShopCartRepository : IShopCartRepository
{
    private readonly IDatabaseAsync _redisDatabase;

    public ShopCartRepository(IConnectionMultiplexer multiplexer)
    {
        _redisDatabase = multiplexer.GetDatabase();
    }
    
    
    public async Task<ShopCart> GetCart() =>  await _redisDatabase.GetRedisCache<ShopCart>("Cart");

    private async Task SetCart(ShopCart cart) => await _redisDatabase.SetRedisCache("Cart", cart);
    
    public async Task AddItem(Product item, int quantity)
    {
        var cart = await GetCart() ?? new ShopCart();

        var shopItem = cart.ShopCartItems.FirstOrDefault(p => p.Product.Id == item.Id);
        if (shopItem is not null) shopItem.Quantity += quantity;
        else cart.ShopCartItems.Add(new ShopCartItem {Product = item, Quantity = quantity});

        await SetCart(cart);

    }

    public async Task DeleteItem(Guid id)
    {
        var cart = await GetCart();
        var shopItem = cart.ShopCartItems.FirstOrDefault(p => p.Product.Id == id);
        if (shopItem != null)
            cart.ShopCartItems.Remove(shopItem);
        await SetCart(cart);


    }

    public async Task Clear()
    {
        var cart = await GetCart();
        cart.ShopCartItems.Clear();
        await SetCart(cart);
    } 
    
}