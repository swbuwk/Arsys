using Arsys.API.Application.Common.Mappings;
using Arsys.API.Application.MediatR.Supplies.Commands.RegisterSupply;
using Arsys.Domain.Entities.Common;
using Arsys.Domain.Entities.Storage;

namespace Arsys.API.DTOs.Storage.SuppliesDto
{
    public class RegisterSupplyDto : IMapWith<RegisterSupplyCommand>
    {
        public DateTime SupplyDate { get; set; }
        public bool IsComplete { get; set; }
        public IEnumerable<Product> Products { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<RegisterSupplyDto, RegisterSupplyCommand>()       
                .ForMember(dto => dto.SupplyDate,
                opt => opt.MapFrom(supply => supply.SupplyDate))
                .ForMember(dto => dto.IsComplete,
                opt => opt.MapFrom(supply => supply.IsComplete))
                .ForMember(dto => dto.Products,
                opt => opt.MapFrom(supply => supply.Products));
        }
    }
}
