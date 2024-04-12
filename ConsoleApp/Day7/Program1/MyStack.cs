using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.Program1
{
    internal class MyStack<T>
    {
        List<T> stack = new List<T> ();

        public int Count()
        {
            return stack.Count;
        }

        public T Pop()
        {
            T t = stack[stack.Count - 1];
            stack.RemoveAt (stack.Count - 1);

            return t;
        }

        public void Push(T t)
        {
            stack.Add(t);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < stack.Count; i++)
            {
                if (i == 0)
                    sb.Append(stack[i].ToString());
                else
                    sb.Append($", {stack[i].ToString()}");
            }
            return sb.ToString();
        }
    }
}
