/*
 * Florentino Aguirre
 * CPSC 23000-LT1 .NET Programming 
 * Week 1 Lab Assignment
 * Projected Raises
 * This program calculates the projected salary for three employees after a 4% raise.
 * Displays the current salaries and new salaries.
 */

using System;

namespace ProjectedRaises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constants including the raise percentage
            const double RAISE_PERCENT = 0.04;
            double salary1 = 50000;
            double salary2 = 60000;
            double salary3 = 70000;

            // Update the salaries with a 4% raise
            double newSalary1 = salary1 * (1 + RAISE_PERCENT);
            double newSalary2 = salary2 * (1 + RAISE_PERCENT);
            double newSalary3 = salary3 * (1 + RAISE_PERCENT);

            // Display the current and new salaries
            Console.WriteLine("Employee 1 current salary: {0:C}", salary1);
            Console.WriteLine("Employee 1 next year's salary: {0:C}", newSalary1);
            Console.WriteLine();
            Console.WriteLine("Employee 2 current salary: {0:C}", salary2);
            Console.WriteLine("Employee 2 next year's salary: {0:C}", newSalary2);
            Console.WriteLine();
            Console.WriteLine("Employee 3 current salary: {0:C}", salary3);
            Console.WriteLine("Employee 3 next year's salary: {0:C}", newSalary3);
        }
    }
}
