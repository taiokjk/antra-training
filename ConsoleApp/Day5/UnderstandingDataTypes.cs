using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class UnderstandingDataTypes
    {
        internal void NumOfBytes()
        {
            string[] types = {"sbyte", "byte", "short", "ushort",
                "int", "uint", "long", "ulong", "float", "double",
                "decimal"};
            int[] bytes = {1, 1, 2, 2,
                4, 4, 8, 8, 4, 8,
                16};

            Console.WriteLine("{0,-20} {1,5}\n", "Type", "Bytes");
            for (int i = 0; i < types.Length; i++)
            {
                Console.WriteLine("{0,-20} {1,5}", types[i], bytes[i]);
            }
        }

        internal void PrintCenteries(int centeries)
        {
            int years = centeries * 100;
            int days = centeries * 36524;
            uint hours = (uint)days * 24;
            uint minutes = hours * 60;
            ulong seconds = minutes * 60;
            ulong milliseconds = seconds * 1000;
            ulong microseconds = milliseconds * 1000;
            ulong nanoseconds = microseconds * 1000;

            Console.WriteLine($"{centeries} centeries = {years} years = " +
                $"{days} days = {hours} hours = {minutes} minutes = " +
                $"{seconds} seconds = {milliseconds} miliseconds = " +
                $"{microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
