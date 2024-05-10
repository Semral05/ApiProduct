using ApiProduct.Service.DTOs.Category;
using ApiProduct.Service.DTOs.Product;
using ApiProduct.Service.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProduct.Service.Services.Interfaces
{
    public interface IProductService
    {
        public Task<ApiResponse> CreateAsync(ProductPostDTO dto);
        public Task<ApiResponse> UpdateAsync(int id, ProductPutDTO dto);
        public Task<ApiResponse> GetAllAsync();
        public Task<ApiResponse> GetByIdAsync(int id);
        public Task<ApiResponse> DeleteAsync(int id);
    }
}
