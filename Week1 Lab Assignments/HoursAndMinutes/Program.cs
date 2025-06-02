/*
 * Florentino Aguirre
 * CPSC 23000 .NET Programming
 * Week 1 Lab Assignment
 * Hours and Minutes Calculation
 * This code is part of a .NET project that calculates the number of hours and minutes from a given total number of minutes.
 * It uses basic arithmetic operations to convert minutes into hours and remaining minutes.
 */

namespace HoursAndMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable to hold the total number of minutes
            int minutes = 197;

            // Calculate the number of hours and remaining minutes
            int hours = minutes / 60;
            int remainingMinutes = minutes % 60;

            // Output the result to the console
            Console.WriteLine("{0} minutes is {1} hours and {2} minutes.", minutes, hours, remainingMinutes);

        }
    }
}
