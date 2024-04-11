using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7InClass.Repository
{
    internal interface IRepository<T> where T : class
    {
        int Insert(T obj);
        int Update(T obj);
        int Delete(int Id);
        List<T> GetAll();
        T GetById(int Id);
    }
}
