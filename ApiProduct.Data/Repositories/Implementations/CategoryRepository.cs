using ApiProduct.Data.Context;
using ApiProduct.Core.Models;
using ApiProduct.Core.Repository.Interfaces;
using ApiProduct.Core.Models.BaseModel;

namespace ApiProduct.Repository.Implementations
{
    public class CategoryRepository : Repository<Category> ,ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {

        }
    }
}
