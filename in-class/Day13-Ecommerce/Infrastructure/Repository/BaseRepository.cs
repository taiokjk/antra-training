using Core.RepositoryContracts;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly EcommerceDbContext _context;

        public BaseRepository(EcommerceDbContext c)
        {
            _context = c;
        }

        public int Delete(int id)
        {
            var entity = GetById(id);

            if (entity == null)
                return 0;

            _context.Set<T>().Remove(entity);
            return _context.SaveChanges();
        }

        public IEnumerable<T> Filter(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().AsEnumerable();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public int Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            return _context.SaveChanges();
        }

        public int Update(T entity)
        {
            _context.Set<T>().Entry(entity).State = EntityState.Modified;
            return _context.SaveChanges();
        }
    }
}
