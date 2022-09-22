using Arsys.API.Application.Common.Mappings;
using Arsys.Domain.Entities.Storage;

namespace Arsys.API.DTOs.Storage.SuppliesDto
{
    public class SupplyLookupDto : IMapWith<Supply>
    {
        public Guid Id { get; set; }
        public DateTime SupplyDate { get; set; }
        public bool IsComplete { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Supply, SupplyDto>() //прописывать связи для полей необязательно
                .ForMember(dto => dto.Id,
                opt => opt.MapFrom(supply => supply.Id))
                .ForMember(dto => dto.SupplyDate,
                opt => opt.MapFrom(supply => supply.SupplyDate))
                .ForMember(dto => dto.IsComplete,
                opt => opt.MapFrom(supply => supply.IsComplete));
        }
    }
}
