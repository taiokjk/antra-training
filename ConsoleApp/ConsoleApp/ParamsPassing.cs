using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class ParamsPassing
    {
        public void PassByValue(int a, int b)
        {
            a = 80;
            b = 50;
            Console.WriteLine($"in PassByValue, a={a}, b={b}");
        }

        public void PassByRef(ref int? a, ref int b)
        {
            a = 80;
            b = 50;
            Console.WriteLine($"in PassByRef, a={a}, b={b}");
        }

        public void AreaOfCirle(double radius, double pi = Math.PI)
        {
            Console.WriteLine($"Area = {pi * Math.Pow(radius, 2.00)}");
        }

        public bool isAuthentic(string username, string password, out string msg)
        {
            if (username == "root" && password == "linux") {
                msg = "success";
                return true;
            }
            else
            {
                msg = "failed";
                return false;
            }
        }

        [Obsolete("Use AddNumbers", error: true)]
        public int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }

        public int AddNumbers(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}
