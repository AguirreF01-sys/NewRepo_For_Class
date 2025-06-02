/*
 * Florentino Aguirre
 * CPSC 23000 .NET Programming
 * Week 1 Lab Assignment
 * Eggs
 * This code is part of a C# console application that calculates the total number of eggs,
 * the number of dozens, and the remaining eggs from four different egg counts.
 */

namespace Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize variables for the number of eggs in each carton
            int eggs1 = 30;
            int eggs2 = 35;
            int eggs3 = 20;
            int eggs4 = 42;

            // Calculate the total number of eggs, dozens, and remaining eggs
            int totalEggs = eggs1 + eggs2 + eggs3 + eggs4;
            int dozens = totalEggs / 12;
            int remainingEggs = totalEggs % 12;

            // Output the results to the console
            Console.WriteLine("Total eggs: {0} is {1} dozen and {2} eggs.", totalEggs, dozens, remainingEggs);
        }
    }
}
