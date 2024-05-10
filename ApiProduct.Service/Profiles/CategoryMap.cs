using ApiProduct.Service.DTOs.Category;
using ApiProduct.Core.Models;
using AutoMapper;
using ApiProduct.Core.Models.BaseModel;

namespace ApiProduct.Service.Profiles
{
    public class CategoryMap : Profile
    {
        public CategoryMap() 
        {
            CreateMap<CategoryPostDTO, Category>();
            CreateMap<CategoryPutDTO, Category>();
            CreateMap<Category, CategoryGetDTO>();
        }
    }
}
