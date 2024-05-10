using System.Linq.Expressions;

namespace ApiProduct.Core.Repository.Interfaces
{
    public interface IRepository<T>
    {
        public Task AddAsync(T model);
        public void Update(T model);
        public Task<List<T>> GetAllAsync(Expression<Func<T,bool>> exp);
        public Task<T> GetByIdAsync(Expression<Func<T,bool>> exp);
        public int Save();
        public Task<int> SaveAsync();
        public bool IsExist(Expression<Func<T,bool>> exp);
    }
}
