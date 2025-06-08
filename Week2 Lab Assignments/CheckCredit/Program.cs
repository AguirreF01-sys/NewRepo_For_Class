/* Florentino Aguirre
 * CPSC 23000 .NET Programming
 * Week 2 Lab Assignment
 * Check Credit
 * This code is part of a console application that checks if a purchase price is valid.
 * If the price is less than or equal to 8000, it approves the transaction.
 * Otherwise, it prompts the user to enter a valid price again.
 */

using System;

namespace CheckCredit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LCV - Loop Control Variable
            bool isValid = false;

            // Display greeting and prompt for input
            Console.WriteLine("Good Morning");
            Console.WriteLine("Please enter purchase price for an item: ");

            // Loop until a valid purchase price is entered
            while (isValid == false)
            {
                // Read user input and try to parse it as a decimal
                string input = Console.ReadLine();

                if (decimal.TryParse(input, out decimal purchasePrice) && purchasePrice < 8001 )
                {
                    // If the purchase price is valid, approve the transaction
                    Console.WriteLine("Transaction Approved");
                    // Set the loop control variable to true to exit the loop
                    isValid = true;
                }
                else
                {
                    // If the purchase price is invalid, prompt the user to enter a valid price again
                    Console.WriteLine("Error: Insufficient Funds");
                }
            }
        }
    }
}
