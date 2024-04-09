using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class LoopsAndOperators
    {
        internal void FizzBuzz(int stopPoint)
        {
            for (int i = 0; i < stopPoint; i++)
            {
                Console.Write($"i = {i}");
                if (i % 3 == 0 && i % 5 == 0)
                    Console.Write(": /fizzbuzz/");
                else if (i % 3 == 0)
                    Console.Write(": /fizz/");
                else if (i % 5 == 0)
                    Console.Write(": /buzz/");
                Console.WriteLine();
            }
        }

        internal void GuessingGame()
        {
            string continueOn = "yes";
            List<String> continueOnList = new List<string> { "y", "yes" };

            Console.WriteLine("Start Guessing Game");
            while (continueOnList.Contains(continueOn))
            {
                Console.Write("Enter your guess from 1 to 3: ");
                int correctNumber = new Random().Next(3) + 1;
                int guessedNumber = int.Parse(Console.ReadLine());

                while (guessedNumber < 1 
                    || guessedNumber > 3 
                    || guessedNumber != correctNumber)
                {
                    if (guessedNumber < 1 || guessedNumber > 3)
                        Console.Write("Guessed number out of range. " +
                            "Please enter a valid guess: ");
                    else if (guessedNumber < correctNumber)
                        Console.Write("You guessed low. Try again: ");
                    else if (guessedNumber > correctNumber)
                        Console.Write("You guessed high. Try again: ");
                    guessedNumber = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Your guess was correct!");

                Console.Write("Do you want to continue? (Y/N): ");
                continueOn = Console.ReadLine().ToLower();
            }
        }

        internal void PrintAPyramid(int numberOfRows)
        {
            for (int row = 0; row < numberOfRows; row++)
            {
                int stars = 1 + row * 2;
                int spaces = (int)(((1 + numberOfRows * 2) - stars)/2);

                Console.Write(new string(' ', spaces));
                Console.WriteLine(new string('*', stars));
            }
        }

        internal void BirthDay()
        {
            Console.Write("Enter your birthday (m/d/yyyy): ");
            string inputBirthday = Console.ReadLine();
            DateTime birthday = DateTime.ParseExact(inputBirthday, "M/d/yyyy", CultureInfo.InvariantCulture);

            int days = (int)(DateTime.Now - birthday).TotalDays;
            int daysToNextAnniversary = 10000 - (days % 10000);

            Console.WriteLine($"You are {days} days old! " +
                $"There are {daysToNextAnniversary} days until your next " +
                $"10,000 days anniversary.");
        }

        internal void Greeting()
        {
            DateTime now = DateTime.Now;

            if (now.Hour < 4)
                Console.WriteLine("Good Night");
            else if (now.Hour < 12)
                Console.WriteLine("Good Morning");
            else if (now.Hour < 15)
                Console.WriteLine("Good Afternoon");
            else if (now.Hour < 19)
                Console.WriteLine("Good Evening");
            else
                Console.WriteLine("Good Night");
        }

        internal void Counting()
        {
            for (int increment = 1; increment < 5; increment++)
            {
                for (int i = 0; i < 25;)
                {
                    if (i == 0)
                        Console.Write(i);
                    else
                        Console.Write($",{i}");
                    i += increment;
                }
                Console.WriteLine();
            }
        }
    }
}
