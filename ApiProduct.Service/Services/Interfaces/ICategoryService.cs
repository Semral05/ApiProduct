using ApiProduct.Service.DTOs.Category;
using ApiProduct.Core.Models;
using ApiProduct.Service.Responses;

namespace ApiProduct.Service.Services.Interfaces
{
    public interface ICategoryService
    {
        public Task<ApiResponse> CreateAsync(CategoryPostDTO dto);
        public Task<ApiResponse> UpdateAsync(int id, CategoryPutDTO dto);
        public Task<ApiResponse> GetAllAsync();
        public Task<ApiResponse> GetByIdAsync(int id);
        public Task<ApiResponse> DeleteAsync(int id);
    }
}
