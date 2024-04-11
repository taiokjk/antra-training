using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.Program1
{
    internal static class Helpers
    {
        internal static int[] GenerateNumbers(int i = 10)
        {
            int[] numbers = new int[i];

            for (int j = 0; j < numbers.Length; j++)
            {
                numbers[j] = j;
            }

            return numbers;
        }

        internal static void PrintNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                    Console.Write(numbers[i]);
                else
                    Console.Write($", {numbers[i]}");
            }
            Console.WriteLine();
        }

        internal static void Reverse(int[] numbers)
        {
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                (numbers[numbers.Length - i - 1], numbers[i]) = (numbers[i], numbers[numbers.Length - i - 1]);
            }
        }
    }
}
