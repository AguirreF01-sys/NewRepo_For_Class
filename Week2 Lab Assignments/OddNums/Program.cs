/* Florentino Aguirre 
 * CPSC 23000 .NET Programming
 * Week 2 Lab Assignment
 * OddNums program
 * This program prints all odd numbers from 1 to 99.
 */

namespace OddNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display a message to the user
            Console.WriteLine("Odd Numbers from 1-99");

            // LCV (Loop Control Variable) to hold the current number
            int num = 1;

            // while loop to iterate through numbers from 1 to 99
            while (num < 100)
            {
                // Check if the number is odd
                if (num % 2 != 0)
                {
                    // Print the odd number to the console
                    Console.WriteLine(num);
                }
                // Increment the number by 1
                num++;
            }
        }
    }
}
