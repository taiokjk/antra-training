using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8InClass
{
    internal class PreDefinedDelegates
    {
        public void Fibonacci(int length)
        {
            int a = 0, b = 1, c = 0;

            for (int i = 0; i < length; i++)
            {
                if (i == 0)
                    Console.Write(a);
                else
                    Console.Write($", {a}");
                c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine();
        }

        public void ActionExample()
        {
            //Action<int> fib = new Action<int>(Fibonacci);
            //fib(10);
            Action<int> fib = delegate (int length)
            {
                int a = 0, b = 1, c = 0;

                for (int i = 0; i < length; i++)
                {
                    if (i == 0)
                        Console.Write(a);
                    else
                        Console.Write($", {a}");
                    c = a + b;
                    a = b;
                    b = c;
                }
                Console.WriteLine();
            };

            Action<int> fibAnotherWay = ((length) => {
                int a = 0, b = 1, c = 0;

                for (int i = 0; i < length; i++)
                {
                    if (i == 0)
                        Console.Write(a);
                    else
                        Console.Write($", {a}");
                    c = a + b;
                    a = b;
                    b = c;
                }
                Console.WriteLine();
            });

            fib(10);
            fibAnotherWay(10);
        }

        public void PredicateDemo()
        {
            Predicate<string> palindrome = (str) =>
            {
                bool isPalindrome = true;
                for (int i = 0; i < str.Length/2; i++)
                {
                    if (str[i] != str[str.Length-1-i])
                    {
                        isPalindrome = false;
                        break;
                    }
                }

                return isPalindrome;
            };

            Console.WriteLine(palindrome("ABCDCBA"));
            Console.WriteLine(palindrome("ABCDDBA"));
        }

        public void FuncExample()
        {
            Func<int, string> factorial = (number) =>
            {
                int f = 1;

                for (int i = number; i > 1; i--)
                {
                    f = f * i;
                }

                return f.ToString();
            };

            Console.WriteLine(factorial(5));
        }
    }
}
