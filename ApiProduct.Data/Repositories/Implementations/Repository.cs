using ApiProduct.Data.Context;
using ApiProduct.Core.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ApiProduct.Repository.Implementations
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T model)
        {
            await _context.Set<T>().AddAsync(model);
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> exp)
        {
            return await _context.Set<T>().Where(exp).ToListAsync(); 
        }

        public async Task<T> GetByIdAsync(Expression<Func<T, bool>> exp)
        {
            return await _context.Set<T>().Where(exp).FirstOrDefaultAsync();
        }

        public bool IsExist(Expression<Func<T, bool>> exp)
        {
            return _context.Set<T>().Where(exp).Count() > 0;
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Update(T model)
        {
            _context.Update(model);
        }

    }
}
