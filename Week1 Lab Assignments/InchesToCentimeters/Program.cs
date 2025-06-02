/*
 * Florentino Aguirre
 * CPSC 23000 .NET Programming
 * Week 1 Lab Assignment
 * Inch to Centimeters Calculator 
 * Program will take inch value and display the conversion amount for centimeters. 
 */

using System;

namespace InchesToCentimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variable to hold the conversion factor from inches to centimeters
            const double cmPerInch = 2.54;

            // variable to hold the number of inches
            double inches = 3;

            // calculate the equivalent centimeters
            double centimeters = inches * cmPerInch;

            // display the result
            Console.WriteLine("{0} inches is {1} centimeters.", inches, centimeters);
        }
    }
}
