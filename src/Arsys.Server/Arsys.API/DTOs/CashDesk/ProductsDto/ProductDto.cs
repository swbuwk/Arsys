using Arsys.API.Application.Common.Mappings;
using Arsys.Domain.Entities.Common;

namespace Arsys.API.DTOs.CashDesk.ProductsDto
{
    public class ProductDto : IMapWith<Product>
    {        
        public Guid Id { get; set; }
        
        public Guid CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Product, ProductDto>()
                .ForMember(dto => dto.Id,
                opt => opt.MapFrom(p => p.Id))
                .ForMember(dto => dto.CategoryId,
                opt => opt.MapFrom(p => p.CategoryId))
                .ForMember(dto => dto.Name,
                opt => opt.MapFrom(p => p.Name))
                .ForMember(dto => dto.Description,
                opt => opt.MapFrom(p => p.Description))
                 .ForMember(dto => dto.ImageUrl,
                opt => opt.MapFrom(p => p.ImageUrl))
                  .ForMember(dto => dto.Price,
                opt => opt.MapFrom(p => p.Price));
        }
    }
}
