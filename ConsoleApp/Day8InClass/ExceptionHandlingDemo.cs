using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8InClass
{
    internal class ExceptionHandlingDemo
    {
        public int Divide(int number, int divisor)
        {
            return number / divisor;
        }

        public int Calculate(int num1, int num2, string operation)
        {
            if (operation == "/")
                return Divide(num1, num2);
            else
                throw new ArgumentOutOfRangeException();
        }
    }
}
