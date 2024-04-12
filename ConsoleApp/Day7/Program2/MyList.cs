using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.Program2
{
    internal class MyList<T>
    {
        List<T> list = new List<T>();

        public void Add(T element)
        {
            list.Add(element);
        }

        public T Remove(int index)
        {
            T t = list[index];
            list.RemoveAt(index);

            return t;
        }

        public bool Contains(T element)
        {
            return list.Contains(element);
        }

        public void Clear() 
        {
            list.Clear();
        }

        public void InsertAt(T element, int index)
        {
            list.Insert(index, element);
        }

        public void DeleteAt(int index)
        {
            list.RemoveAt(index );
        }

        public T Find(int index)
        {
            return list[index];
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < list.Count; i++)
            {
                if (i == 0)
                    sb.Append(list[i].ToString());
                else
                    sb.Append($", {list[i].ToString()}");
            }
            return sb.ToString();
        }
    }
}
