/* Florentino Aguirre
 * CPSC 23000 .NET Programming
 * Week 2 Lab Assignment
 * Multiplication Table Generator
 * This program generates a multiplication table for a given positive integer.
 * It prompts the user to enter a number and displays the multiplication table from 1 to 10.
 */

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message
            Console.WriteLine("Welcome to Multiplication Table");
            // Prompt user for input
            Console.WriteLine("Enter a number to generate its multiplication table:");
            
            if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
            {
                Console.WriteLine($"Multiplication table for {number}:");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{number} x {i} = {number * i}");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid positive integer.");
            }
        }
    }
}
