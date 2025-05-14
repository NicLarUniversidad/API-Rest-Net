using AutoMapper;
using APIRest.Domains.DataTransferObjects;
using Models.Entities;

namespace APIRest.Domains.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductEntity, ProductDto>();
            CreateMap<ProductDto, ProductEntity>();
            CreateMap<AddProductDto, ProductEntity>();

            CreateMap<CategoryEntity, CategoryDto>();
            CreateMap<CategoryDto, CategoryEntity>();
        }
    }
}
