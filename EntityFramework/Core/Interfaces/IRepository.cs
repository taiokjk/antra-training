using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IRepository<T> where T: class
    {
        int Insert(T obj);
        int DeleteById(int id);
        int Update(T obj);
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
