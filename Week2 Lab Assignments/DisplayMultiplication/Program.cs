/* Florentino Aguirre
 * CPSC 23000 .NET Programming
 * Week 2 Lab Assignment
 * Display Multiplication Table
 * This code displays a multiplication table from 1 to 10.
 * Each number is formatted to take up 5 spaces for better alignment.
 */

namespace DisplayMultiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display Header
            Console.WriteLine("Multiplication table 1-10");

            // For Loop to generate multiplication table
            for (int i = 1; i <= 10; i++)
            {
                // Display each row of the multiplication table
                for (int j = 1; j <= 10; j++)
                {
                    // Format each product to take up 5 spaces
                    Console.Write($"{i * j,5}");
                }
                // Move to the next line after each row
                Console.WriteLine();
            }
        }
    }
}
