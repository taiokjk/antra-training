using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.Program2
{
    internal static class Helpers
    {
        public static int Fibonacci(int position)
        {
            position--;
            if (position < 2)
                return 1;

            int[] fib = new int[2];
            fib[0] = 1;
            fib[1] = 1;

            for (int i = 0; i < position - 1; i++)
            {
                fib[i%2] = fib[0] + fib[1];
            }

            return fib[position%2];
        }
    }
}
