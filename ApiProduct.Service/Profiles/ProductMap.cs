using ApiProduct.Core.Models.BaseModel;
using ApiProduct.Service.DTOs.Product;
using AutoMapper;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProduct.Service.Profiles
{
    public class ProductMap : Profile
    {
        public ProductMap() 
        {
            CreateMap<ProductGetDTO, Product>();
            CreateMap<Product, ProductPostDTO>();
            CreateMap<Product, ProductPutDTO>();
        }
    }
}
