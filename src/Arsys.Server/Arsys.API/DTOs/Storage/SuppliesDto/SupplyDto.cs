using Arsys.API.Application.Mappings;
using Arsys.Domain.Entities.Common;
using Arsys.Domain.Entities.Storage;

namespace Arsys.API.DTOs.Storage.SuppliesDto
{
    public class SupplyDto : IMapWith<Supply>
    {
        public Guid Id { get; set; }
        public DateTime SupplyDate { get; set; }
        public bool IsComplete { get; set; }
        public IEnumerable<Product> Products { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Supply, SupplyDto>()
                .ForMember(dto => dto.Id,
                opt => opt.MapFrom(supply => supply.Id))
                .ForMember(dto => dto.SupplyDate,
                opt => opt.MapFrom(supply => supply.SupplyDate))
                .ForMember(dto => dto.IsComplete,
                opt => opt.MapFrom(supply => supply.IsComplete))
                .ForMember(dto => dto.Products,
                opt => opt.MapFrom(supply => supply.Products));
        }
    }
}
