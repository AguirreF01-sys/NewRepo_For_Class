/* Florentino Aguirre
 * CPSC 23000 .NET Programming
 * Week 2 Lab Assignment
 * Admission Program
 * This program checks if a student is admitted based on GPA and test score. 
 * If the GPA is 3.0 or higher and the test score is 60 or higher, 
 * or if the test score is 80 or higher, the student is admitted.
 */

namespace Admission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Welcome message 
            Console.WriteLine("Welcome to the Admission Office!\n");

            // Prompt user for GPA and test score
            Console.WriteLine("Enter your grade point average: ");
            string? inputGpa = Console.ReadLine();
            Console.WriteLine("Enter your admission test score: ");
            string? inputScore = Console.ReadLine();

            // Validate input and determine admission status
            if (double.TryParse(inputGpa, out double gpa) && double.TryParse(inputScore, out double score))
            {
                // GPA and score conditions for admission
                if ((gpa >= 3.0 && score >= 60) || score >= 80)
                {
                    // If conditions are met, inform the user of admission
                    Console.WriteLine("Congratulations! You have been admitted.");
                }
                else
                {
                    // If conditions are not met, inform the user of rejection
                    Console.WriteLine("We regret to inform you that you have not been admitted.");
                }
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("Invalid input. Please enter numeric values for GPA and test score.");
            }
        }
    }
}
