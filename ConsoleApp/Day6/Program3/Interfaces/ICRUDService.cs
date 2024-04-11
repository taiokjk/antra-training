using Day6.Program3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.Program3.Interfaces
{
    internal interface ICRUDService<T> where T : Base
    {
        bool Create(T t);
        List<T> GetAll();
        T GetById(int id);
        bool Update(T t);
        bool Delete(int id);
    }
}
