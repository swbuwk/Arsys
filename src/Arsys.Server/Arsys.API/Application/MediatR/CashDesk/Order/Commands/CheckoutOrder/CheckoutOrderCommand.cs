using Arsys.API.Application.Mappings;
using Arsys.Domain.Entities.CashDesk;

namespace Arsys.API.Application.MediatR.CashDesk.Order.Commands.CheckoutOrder;

public class CheckoutOrderCommand : IRequest, IMapWith<Domain.Entities.CashDesk.Order>
{
    public string CustomerName { get; set; }
    
    public string CustomerSurname { get; set; }
    
    public string Adress { get; set; }
    
    public string Email { get; set; }
    
    public void Mapping(Profile profile)
    {
        profile.CreateMap<CheckoutOrderCommand, Domain.Entities.CashDesk.Order>()
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
