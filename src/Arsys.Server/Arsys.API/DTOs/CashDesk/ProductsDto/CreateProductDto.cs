using Arsys.API.Application.Common.Mappings;
using Arsys.API.Application.MediatR.Products.Commands.CreateProduct;
using Arsys.API.Application.MediatR.Products.Commands.UpdateProduct;

namespace Arsys.API.DTOs.CashDesk.ProductsDto
{
    public class CreateProductDto : IMapWith<CreateProductCommand>
    {
        public Guid CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateProductDto, CreateProductCommand>()                
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
