using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Arrays
    {
        internal void CopyArray()
        {
            int[] arr1 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            int[] arr2 = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }

            Console.Write("arr1: ");
            for (int i = 0; i < arr1.Length; i++)
            {
                if (i == 0)
                    Console.Write(arr1[i]);
                else
                    Console.Write($", {arr1[i]}");
            }
            Console.WriteLine();

            Console.Write("arr2: ");
            for (int i = 0; i < arr2.Length; i++)
            {
                if (i == 0)
                    Console.Write(arr2[i]);
                else
                    Console.Write($", {arr2[i]}");
            }
            Console.WriteLine();
        }

        internal void GroceryList()
        {
            string continueOn = "yes";
            List<string> continueOnList = new List<string> { "y", "yes" };
            List<string> groceryList = new List<string>();
            Console.WriteLine("Grocery List started");

            while (continueOnList.Contains(continueOn))
            {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
                string answer = Console.ReadLine();

                string option = answer[..2];
                string item;
                switch (option)
                {
                    case "+ ":
                        item = answer[2..];
                        groceryList.Add(item);
                        Console.WriteLine($"Item {item} added to the list");
                        break;
                    case "- ":
                        item = answer[2..];
                        bool removed = groceryList.Remove(item);
                        if (removed)
                            Console.WriteLine($"Item {item} removed from the list");
                        else
                            Console.WriteLine($"Item {item} does not exist in the list");
                        break;
                    case "--":
                        groceryList.Clear();
                        break;
                    default:
                        Console.WriteLine("Invalid command.");
                        break;
                }

                Console.WriteLine("Current grocery list:");
                int i = 1;
                foreach (string groceryItem in groceryList)
                {
                    Console.WriteLine($"{i}. {groceryItem}");
                    i++;
                }

                Console.Write("Do you want to continue? (Y/N): ");
                continueOn = Console.ReadLine().ToLower();
            }
        }

        internal int[] FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primeNumbers = new List<int>();

            for (int i = startNum; i <= endNum; i++)
            {
                if (i == 0 || i == 1)
                    primeNumbers.Add(i);
                else
                {
                    bool isPrime = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                        primeNumbers.Add(i);
                }
            }

            return primeNumbers.ToArray();
        }

        internal int[] SumRotate(int[] arr, int rotations)
        {
            int[] sum = new int[arr.Length];
            Array.Clear(sum);

            for (int i = 0; i < rotations; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    sum[j] += arr[(j + i + arr.Length - rotations) % arr.Length];
                }
            }

            return sum;
        }

        internal void LongestSequence(int[] arr)
        {
            int longest = 1;
            int current = 1;
            int longestValue = arr[0];
            List<int> sequence = new List<int>();

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                    ++current;
                else
                    current = 1;

                if (current > longest)
                {
                    longest = current;
                    longestValue = arr[i];
                }
            }

            for (int i = 0; i < longest; i++)
            {
                Console.Write($"{longestValue} ");
            }
            Console.WriteLine();
        }

        internal void MostFrequent(int[] arr)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int key = arr[i];
                if (map.ContainsKey(key))
                {
                    map[key] += 1;
                }
                else
                    map[key] = 1;
            }

            int count = 0;
            int mostFrequent = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int key = arr[i];
                if (map[key] > count)
                {
                    count = map[key];
                    mostFrequent = arr[i];
                }
            }

            Console.WriteLine($"Most frequent is: {mostFrequent}");
        }
    }
}
