using AutoMapper;
using CleanArch.Domain.Entities;
using CleanArch.Infra.API.DTO;

namespace CleanArch.Infra.API.Mapper
{
    public class CategoryMapper : Profile
    {
        public CategoryMapper()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
        }
    }
}
