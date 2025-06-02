/*
 * Florentino Aguirre
 * CPSC 23000-LT1 .NET Programming 
 * Week 1 Lab Assignment
 * ProjectedRaises
 * This program calculates the projected salary for three employees after a 4% raise.
 * It prompts the user to input the current salaries and displays the new salaries.
 */

using System;

namespace ProjectedRaisesInteractive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable to hold the raise percentage
            const double raisePercent = 0.04;

            // Prompt the user for the salaries of three employees using a method to read input
            Console.Write("Enter salary for employee 1: ");
            double salary1 = ReadDoubleFromConsole();

            Console.Write("Enter salary for employee 2: ");
            double salary2 = ReadDoubleFromConsole();

            Console.Write("Enter salary for employee 3: ");
            double salary3 = ReadDoubleFromConsole();

            // update the salaries with the raise percentage
            double newSalary1 = salary1 * (1 + raisePercent);
            double newSalary2 = salary2 * (1 + raisePercent);
            double newSalary3 = salary3 * (1 + raisePercent);

            // Display the new salaries
            Console.WriteLine();
            Console.WriteLine("Employee 1 next year's salary: {0:C}", newSalary1);
            Console.WriteLine("Employee 2 next year's salary: {0:C}", newSalary2);
            Console.WriteLine("Employee 3 next year's salary: {0:C}", newSalary3);
        }

        //Function to read a double value from the console with validation
        private static double ReadDoubleFromConsole()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (double.TryParse(input, out double result))
                {
                    return result;
                }
                else
                {
                    Console.Write("Invalid input. Please enter a numeric value: ");
                }
            }
        }
    }
}
