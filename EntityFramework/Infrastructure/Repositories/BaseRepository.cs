using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private DbContextDemo _dbContext = new DbContextDemo();

        public int DeleteById(int id)
        {
            var entity = _dbContext.Set<T>().Find(id);
            if (entity != null)
            {
                _dbContext.Set<T>().Remove(GetById(id));
                _dbContext.SaveChanges();
                return 1;
            }

            return 0;
        }

        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            var entity = _dbContext.Set<T>().Find(id);
            return entity;
        }

        public int Insert(T obj)
        {
            _dbContext.Set<T>().Add(obj);
            _dbContext.SaveChanges();

            return 1;
        }

        public int Update(T obj)
        {
            _dbContext.Entry(obj).State = EntityState.Modified;
            _dbContext.SaveChanges();

            return 1;
        }
    }
}
