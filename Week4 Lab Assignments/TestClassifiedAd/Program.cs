/* Florentino Aguirre
 * CPSC 23000 .NET Programming
 * Week 4 Lab Assignment
 * TestClassifiedAd.cs
 * This program creates instances of the ClassifiedAd class and displays their details.
 */

using System.Security.Cryptography.X509Certificates;

namespace TestClassifiedAd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate two ClassifiedAd objects with different categories, descriptions, and prices
            ClassifiedAd item1 = new ClassifiedAd("Playstation 5", "Slightly used still functional. Price is not negotiable", 399.99);
            
            ClassifiedAd item2 = new ClassifiedAd("Xbox Series X", "Brand new, never used. Comes with 2 controllers.", 499.99);

            // Display header
            Console.WriteLine("Classified Ads:\n");

            // Display details of item1
            Console.WriteLine(item1.ToString());
            Console.WriteLine($"{item1.Price,0:C}"); // Format price as currency
            Console.WriteLine($"Description Word Count: {item1.DescriptionWordCount}");
            Console.WriteLine("\n---------------------------------\n");

            // Display details of item2
            Console.WriteLine(item2.ToString());
            Console.WriteLine($"{item2.Price,0:C}"); // Format price as currency
            Console.WriteLine($"Description Word Count: {item2.DescriptionWordCount}");
            Console.WriteLine("\n---------------------------------\n");
        }
    }
}
