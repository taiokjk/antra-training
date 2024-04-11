using Day6.Program3.Interfaces;
using Day6.Program3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.Program3.Services
{
    internal abstract class CRUDService<T> : ICRUDService<T> where T : Base
    {
        private List<T> list = new List<T>();

        public bool Create(T t)
        {
            if (GetById(t.Id) == null)
                list.Add(t);

            return false;
        }

        public bool Delete(int id)
        {
            T t = GetById(id);

            if (t != null)
            {
                list.Remove(t);
                return true;
            }

            return false;
        }

        public List<T> GetAll()
        {
            return list;
        }

        public T GetById(int id)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Id == id)
                    return list[i];
            }
            return null;
        }

        public bool Update(T t)
        {
            T tFromList = GetById(t.Id);

            if (tFromList != null)
            {
                tFromList = t;
                return true;
            }

            return false;
        }
    }
}
