using Arsys.API.Application.Mappings;
using Arsys.API.Application.MediatR.CashDesk.ShopCart.Commands.AddItem;

namespace Arsys.API.DTOs.CashDesk.ShopCartDto;

public class AddItemDto : IMapWith<AddItemCommand>
{
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<AddItemDto, AddItemCommand>()
            .ForMember(dto => dto.ProductId,
                opt => opt.MapFrom(p => p.ProductId))
            .ForMember(dto => dto.Quantity,
                opt => opt.MapFrom(p => p.Quantity));
    }
}