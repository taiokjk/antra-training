using Day7.Program3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.Program3.Repositories
{
    internal class GenericRepository<T> : IRepository<T> where T : Entity
    {
        List<T> list = new List<T>();

        public void Add(T item)
        {
            T t = GetById(item.Id);

            if (t != null)
                list.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return list;
        }

        public T GetById(int id)
        {
            for (int i = 0; i < list.Count; i++)
                if (list[i].Id == id)
                    return list[i];

            return null;
        }

        public void Remove(T item)
        {
            T t = GetById(item.Id);

            if (t != null)
                list.Remove(t);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
