using System;

namespace InchesToCentimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double CM_PER_INCH = 2.54;
            Console.Write("Enter measurement in inches: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double inches))
            {
                double centimeters = inches * CM_PER_INCH;
                Console.WriteLine("{0} inches is {1} centimeters.", inches, centimeters);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
