using Arsys.API.Application.Mappings;
using Arsys.API.Application.MediatR.CashDesk.Order.Commands.CheckoutOrder;
using Arsys.API.DTOs.Storage.SuppliesDto;
using Arsys.Domain.Entities.CashDesk;
using Arsys.Domain.Entities.Storage;

namespace Arsys.API.DTOs.CashDesk.OrderDto;

public class OrderDto : IMapWith<CheckoutOrderCommand>
{
    public string CustomerName { get; set; }
    
    public string CustomerSurname { get; set; }
    
    public string Adress { get; set; }
    
    public string Email { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<OrderDto, CheckoutOrderCommand>()
            .ForMember(dto => dto.CustomerName,
                opt => opt.MapFrom(p => p.CustomerName))
            .ForMember(dto => dto.CustomerSurname,
                opt => opt.MapFrom(p => p.CustomerSurname))
            .ForMember(dto => dto.Adress,
            opt => opt.MapFrom(p => p.Adress))
            .ForMember(dto => dto.Email,
            opt => opt.MapFrom(p => p.Email));
            
            
    }
}