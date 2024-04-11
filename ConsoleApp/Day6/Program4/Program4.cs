using Day6.Program4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.Program4
{
    internal static class Program4
    {
        public static void Run()
        {
            Color colorWhite = new Color(255, 255, 255);
            Color colorBlue = new Color(0, 0, 255);

            Ball ballPop5 = new Ball(50, colorWhite);
            Ball ballPop20 = new Ball(100, colorBlue);

            Console.WriteLine("Throw 2 balls 10 times, ballPop5 should pop at 5");
            for (int i = 0; i < 10; i++)
            {
                ballPop5.Throw();
                ballPop20.Throw();
                if (i == 4)
                    ballPop5.Pop();
            }
            Console.WriteLine("After 10 throws:");
            Console.WriteLine($"ballPop5's number of thrown: {ballPop5.NumberOfThrown()}");
            Console.WriteLine($"ballPop20's number of thrown: {ballPop20.NumberOfThrown()}");

            Console.WriteLine("Throw 2 balls 50 more times, ballPop20 should pop at 20");
            for (int i = 0; i < 10; i++)
            {
                ballPop5.Throw();
                ballPop20.Throw();
                if (i == 9)
                    ballPop20.Pop();
            }
            Console.WriteLine("After 50 more throws:");
            Console.WriteLine($"ballPop5's number of thrown: {ballPop5.NumberOfThrown()}");
            Console.WriteLine($"ballPop20's number of thrown: {ballPop20.NumberOfThrown()}");
        }
    }
}
