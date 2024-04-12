using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.Program1
{
    internal static class Program1
    {
        public static void Run()
        {
            Console.WriteLine("Initialize a stack of int type.");
            MyStack<int> stack = new MyStack<int>();

            Console.WriteLine("Push 0, 1, 2, 3 into the stack:");
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.ToString());

            Console.WriteLine("Pop the stack 2 times:");
            stack.Pop();
            stack.Pop();
            Console.WriteLine(stack.ToString());

            Console.Write("Number of elements in the stack: ");
            Console.WriteLine(stack.Count());
        }
    }
}
