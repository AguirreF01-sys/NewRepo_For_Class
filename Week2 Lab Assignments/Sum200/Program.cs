/* Florentino Aguirre 
 * CPSC 23000 .NET Programming
 * Week 2 Lab Assignment
 * Sum of Numbers 1 to 200
 * This code calculates the sum of numbers from 1 to 100 and then from 1 to 200.
 * It uses a simple loop to accumulate the sum and prints the results to the console.
 */

namespace Sum200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display a message
            Console.WriteLine("Sum of 1 to 100");

            // LCV (Loop Control Variable) is used to iterate through numbers and calculate the sum
            int sum = 0;

            // Loop from 1 to 100 and accumulate the sum
            for (int i = 1; i <= 100; i++)
            {
                // Add the current number to the sum
                sum += i;
            }

            // Display the result
            Console.WriteLine($"The sum of numbers from 1 to 100 is: {sum}");
            Console.WriteLine(); // Print a blank line for better readability

            // Display a message for the next calculation
            Console.WriteLine("Sum of 1 to 200");

            // Loop to calculate the sum from 101 to 200
            for (int i = 101; i <= 200; i++)
            {
                // Add the current number to the sum
                sum += i;
            }

            // Display the result for the sum from 1 to 200
            Console.WriteLine($"The sum of numbers from 1 to 200 is: {sum}");
        }
    }
}
