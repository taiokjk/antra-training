using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.Program1
{
    internal static class Program1
    {
        public static void Run()
        {
            int[] numbers = Helpers.GenerateNumbers(10);
            Helpers.Reverse(numbers);
            Helpers.PrintNumbers(numbers);
        }
    }
}
