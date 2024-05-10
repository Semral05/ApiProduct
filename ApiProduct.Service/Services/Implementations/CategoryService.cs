using ApiProduct.Core.Models;
using ApiProduct.Core.Models.BaseModel;
using ApiProduct.Core.Repository.Interfaces;
using ApiProduct.Data.Context;
using ApiProduct.Service.DTOs.Category;
using ApiProduct.Service.Responses;
using ApiProduct.Service.Services.Interfaces;
using AutoMapper;

namespace ApiProduct.Service.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _repository;

        public CategoryService(IMapper mapper, ICategoryRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<ApiResponse> CreateAsync(CategoryPostDTO dto)
        {
            if (_repository.IsExist((x => x.Name.Trim().ToLower() == dto.Name.Trim().ToLower())))
            {
                return new ApiResponse { StatusCode = 400, Description = $"{dto.Name} artıq var." };
            }
            Category category = _mapper.Map<Category>(dto);
            await _repository.AddAsync(category);
            await _repository.SaveAsync();

            return new ApiResponse { Items = category, StatusCode = 201 };
        }

        public async Task<ApiResponse> DeleteAsync(int id)
        {
            Category? category = await _repository.GetByIdAsync(x => !x.IsDeleted && x.Id == id);
            if (category == null)
            {
                return new ApiResponse { StatusCode = 404, Description = "Məlumat tapılmadı" };
            }
            category.IsDeleted = true;
            _repository.Update(category);
            await _repository.SaveAsync();

            return new ApiResponse { Items = category, StatusCode = 200 };
        }

        public async Task<ApiResponse> GetAllAsync()
        {
            IEnumerable<Category> categories = await _repository.GetAllAsync(x => !x.IsDeleted);
            //IQueryable<Category> categories = _context.Categories.AsQueryable();
            //IEnumerable<Category> query = await categories.ToListAsync();
            IEnumerable<CategoryGetDTO> categoryGet = _mapper.Map<IEnumerable<CategoryGetDTO>>(categories);

            return new ApiResponse { Items = categoryGet, StatusCode = 200 };
        }

        public async Task<ApiResponse> GetByIdAsync(int id)
        {
            Category? category = await _repository.GetByIdAsync(x => !x.IsDeleted && x.Id == id);
            if (category == null)
            {
                return new ApiResponse { Items = 404, Description = "Məlumat tapılmadı" };
            }

            CategoryGetDTO dto = _mapper.Map<CategoryGetDTO>(category);
            return new ApiResponse { Items = dto, StatusCode = 200 };
        }

        public async Task<ApiResponse> UpdateAsync(int id, CategoryPutDTO dto)
        {
            Category? updatedCategory = await _repository.GetByIdAsync(x => !x.IsDeleted && x.Id == id);
            if (updatedCategory == null)
            {
                return new ApiResponse { Items = 404, Description = "Məlumat tapılmadı" };
            }
            updatedCategory.Name = dto.Name;
            await _repository.SaveAsync();

            return new ApiResponse { Items = updatedCategory, StatusCode = 200 };
        }
    }
}
