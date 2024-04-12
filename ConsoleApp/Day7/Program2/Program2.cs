using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.Program2
{
    internal static class Program2
    {
        public static void Run()
        {
            Console.WriteLine("Initialize list of int of {0, 1, 3, 4}");
            MyList<int> list = new MyList<int>();
            list.Add(0);
            list.Add(1);
            list.Add(3);
            list.Add(4);

            Console.WriteLine("Added element 2 at index 2. List becomes: ");
            list.InsertAt(2, 2);
            Console.WriteLine(list.ToString());

            Console.WriteLine($"Element at index 4 is: {list.Find(4)}");
            Console.WriteLine($"List contains element with value 5: {list.Contains(5)}");
            
            Console.WriteLine("Added element 6 to the list:");
            list.Add(6);
            Console.WriteLine(list.ToString());

            Console.WriteLine("Deleted element at index 1. The list becomes:");
            list.Remove(1);
            Console.WriteLine(list.ToString());

            Console.WriteLine("Cleared the list:");
            list.Clear();
            Console.WriteLine(list.ToString());
        }
    }
}
