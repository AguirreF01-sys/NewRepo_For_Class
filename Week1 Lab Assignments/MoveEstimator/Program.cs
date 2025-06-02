/*
 * Florentino Aguirre
 * CPSC 23000 .NET Programming
 * Week 1 Lab Assignment
 * Moving Estimator
 * This code is part of a .NET console application that estimates the moving fee based on user input.
 * It calculates the total fee using a base rate, hourly rate, and per mile rate.
 */

namespace MoveEstimator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable declarations for the moving fee calculation
            const double baseRate = 200.0;
            const double ratePerHour = 150.0;
            const double ratePerMile = 2.0;

            // User input for hours 
            Console.Write("Enter the estimated number of hours: ");
            if (!double.TryParse(Console.ReadLine(), out double hours))
            {
                Console.WriteLine("Invalid input for hours.");
                return;
            }
            // User input for miles
            Console.Write("Enter the estimated number of miles: ");
            if (!double.TryParse(Console.ReadLine(), out double miles))
            {
                Console.WriteLine("Invalid input for miles.");
                return;
            }

            // Calculate the total moving fee based on the input
            double totalFee = baseRate + (ratePerHour * hours) + (ratePerMile * miles);

            // Output display the total moving fee
            Console.WriteLine("Total moving fee: {0:C}", totalFee);
        }
    }
}
