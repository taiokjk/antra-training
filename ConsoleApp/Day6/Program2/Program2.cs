using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.Program2
{
    internal static class Program2
    {
        public static void Run()
        {
            Console.WriteLine($"Fibonacci at position 3: {Helpers.Fibonacci(3)}");
            Console.WriteLine($"Fibonacci at position 10: {Helpers.Fibonacci(10)}");
        }
    }
}
