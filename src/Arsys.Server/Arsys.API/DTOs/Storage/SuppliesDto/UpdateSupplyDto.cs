using Arsys.API.Application.Common.Mappings;
using Arsys.API.Application.MediatR.Supplies.Commands.UpdateSupply;
using Arsys.Domain.Entities.Common;

namespace Arsys.API.DTOs.Storage.SuppliesDto
{
    public class UpdateSupplyDto : IMapWith<UpdateSupplyCommand>
    {
        public Guid Id { get; set; }
        public DateTime SupplyDate { get; set; }
        public bool IsComplete { get; set; }
        public IEnumerable<Product> Products { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateSupplyDto, UpdateSupplyCommand>()
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
