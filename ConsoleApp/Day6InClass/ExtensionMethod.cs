using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6InClass
{
    internal static class ExtensionMethod
    {
        public static string EvenOrOdd(this int num)
        {
            if (num%2 == 0)
                return "Even";
            return "Odd";
        }
    }
}
