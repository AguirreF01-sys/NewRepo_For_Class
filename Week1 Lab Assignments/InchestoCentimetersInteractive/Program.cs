/*
 * Florentino Aguirre
 * CPSC 23000 .NET Programming
 * Week 1 Lab Assignment
 * Inch to Centimeters Interactive Calculator 
 * Program will take user input inch value and display the conversion amount for centimeters. 
 */

using System;

namespace InchesToCentimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constant for conversion factor from inches to centimeters
            const double cmPerInch = 2.54;

            // Prompt user for input and store the input
            Console.Write("Enter measurement in inches: ");
            string input = Console.ReadLine();

            // Try to parse the input as a double
            if (double.TryParse(input, out double inches))
            {
                // Calculate centimeters from inches and display the result
                double centimeters = inches * cmPerInch;
                Console.WriteLine("{0} inches is {1} centimeters.", inches, centimeters);
            }
            else
            {
                // If parsing fails, display an error message
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
