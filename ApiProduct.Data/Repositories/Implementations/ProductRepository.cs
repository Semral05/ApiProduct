using ApiProduct.Core.Models.BaseModel;
using ApiProduct.Core.Repositories;
using ApiProduct.Data.Context;
using ApiProduct.Repository.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProduct.Data.Repositories.Implementations
{
    public class ProductRepository : Repository<Product>,IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}
