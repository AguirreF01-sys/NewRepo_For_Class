/*Florentino Aguirre
 * CPSC 23000 .NET Programming
 * Week 2 Lab Assignment
 * Tweeting
 * This program prompts the user to write a post and checks if it is within the 280 character limit for a tweet.
 */

using System;
namespace Tweeting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LCV
            bool isValid = false;
            // Prompt the user to write a post
            Console.WriteLine("Write your post ");
            // while loop to check if the post is valid
            while (!isValid)
            {
                // Read the post from the user
                string post = Console.ReadLine();
                // Check if the post is within the 280 character limit
                if (post.Length > 280)
                {
                    // If the post is too long, prompt the user to try again
                    Console.WriteLine("Your post is too long. Please try again.");
                }
                else
                {
                    // If the post is valid, set isValid to true and print a success message
                    isValid = true;
                    Console.WriteLine("Your post has been accepted");
                }
            }
            
        }
    }
}
