using Core.RepositoryContracts;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class BaseRepositoryAsync<T> : IRepositoryAsync<T> where T : class
    {
        private readonly EcommerceDbContext _context;

        public BaseRepositoryAsync(EcommerceDbContext c)
        {
            _context = c;
        }

        public async Task<int> DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);

            if (entity == null)
                return 0;

            _context.Set<T>().Remove(entity);
            return await _context.SaveChangesAsync();
        }

        public Task<IEnumerable<T>> FilterAsync(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<int> InsertAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            return _context.SaveChanges();
        }

        public async Task<int> UpdateAsync(T entity)
        {
            _context.Set<T>().Entry(entity).State = EntityState.Modified;
            return await _context.SaveChangesAsync();
        }
    }
}
