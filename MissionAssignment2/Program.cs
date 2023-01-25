using System;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array to keep track of the number of times each total is thrown
            int[] totals = new int[13];
            // Welcome player and ask the user how many times to roll the dice
            Console.Write("Welcome to the dice throwing simulator!");
            Console.WriteLine();
            Console.Write("Enter the number of times to roll the dice: ");
            int rolls = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Print results of dice rolls
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each '*' represents 1 % of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + rolls);
            Console.WriteLine();

            // Roll the dice the specified number of times
            Random rnd = new Random();
            for (int i = 0; i < rolls; i++)
            {
                int die1 = rnd.Next(1, 7);
                int die2 = rnd.Next(1, 7);
                int total = die1 + die2;
                totals[total]++;
            }

            // Print the histogram
            for (int i = 2; i <= 12; i++)
            {
                Console.Write(i + ": ");
                double percentage = (double)totals[i] / rolls * 100;
                int stars = (int)percentage;
                for (int j = 0; j < stars; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            // Print exit message to user 
            Console.WriteLine();
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");

            Console.ReadKey();
        }
    }
}