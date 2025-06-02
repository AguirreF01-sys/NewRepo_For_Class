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
            //Variable to store conversion amount
            const double cmPerInch = 2.54;

            //Prompt user to enter inch value and store in variable
            Console.Write("Enter measurement in inches: ");
            string input = Console.ReadLine();

            //As long ans input is appropriate value conversion amount will display
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
