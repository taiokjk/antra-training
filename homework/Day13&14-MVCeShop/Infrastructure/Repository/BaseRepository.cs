using Core.Interfaces.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly EShopDbContext _context;

        public BaseRepository(EShopDbContext context)
        {
            _context = context;
        }

        public int Create(T entity)
        {
            _context.Set<T>().Add(entity);

            return _context.SaveChanges();
        }

        public int Delete(int id)
        {
            var entity = GetById(id);

            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
                return _context.SaveChanges();
            }

            return 0;
        }

        public IEnumerable<T> Filter(Func<T, bool> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().AsEnumerable();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public int Update(T entity)
        {
            _context.Set<T>().Entry(entity).State = EntityState.Modified;
            return _context.SaveChanges();
        }
    }
}
