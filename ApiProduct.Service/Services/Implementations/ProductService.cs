using ApiProduct.Core.Models.BaseModel;
using ApiProduct.Core.Repositories;
using ApiProduct.Core.Repository.Interfaces;
using ApiProduct.Service.DTOs.Product;
using ApiProduct.Service.Responses;
using ApiProduct.Service.Services.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProduct.Service.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public ProductService(IMapper mapper, IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task<ApiResponse> CreateAsync(ProductPostDTO dto)
        {
            if (!_categoryRepository.IsExist(x => x.Id == dto.CategoryId))
            {
                return new ApiResponse { StatusCode = 404, Description = "Category id is not found" }
            }

            Product product = _mapper.Map<Product>(dto);
            await _productRepository.AddAsync(product);
            await _productRepository.SaveAsync();

            return new ApiResponse { StatusCode = 201 };
        }

        public Task<ApiResponse> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> UpdateAsync(int id, ProductPutDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
