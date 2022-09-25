using Arsys.API.Application.Mappings;
using Arsys.Domain.Entities.CashDesk;

namespace Arsys.API.DTOs.CashDesk.ShopCartDto;

public class ShopCartDto : IMapWith<ShopCart>
{
    public List<ShopCartItem> ShopCartItems { get; set; } = new List<ShopCartItem>();
    
    public decimal ComputeCartPrice() =>
        ShopCartItems != null
            ? ShopCartItems.Sum(item => item.Quantity * item.Product.Price)
            : 0;

    public void Mapping(Profile profile)
    {
        profile.CreateMap<ShopCart, ShopCartDto>()
            .ForMember(dto => dto.ShopCartItems,
                opt => opt.MapFrom(p => p.ShopCartItems));
    }
}
