/*
 * * Florentino Aguirre
 * CPSC 23000 .NET Programming
 * Week 1 Lab Assignment
 * Inch to Centimeters Calculator 
 * Program will take user input to represent inch value and display the conversion amount for centimeters. 
 */

using System;

namespace InchesToCentimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double cmPerInch = 2.54;
            Console.Write("Enter measurement in inches: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double inches))
            {
                double centimeters = inches * cmPerInch;
                Console.WriteLine("{0} inches is {1} centimeters.", inches, centimeters);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
