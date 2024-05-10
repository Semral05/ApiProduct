using ApiProduct.Core.Models.BaseModel;
using ApiProduct.Core.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProduct.Core.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
    }
}
