/* Florentino Aguirre
 * CPSC 23000 .NET Programming
 * Week 4 Lab Assignment
 * SalesTransactionDemo
 * This code demonstrates the use of the SalesTransaction class by creating several instances with different parameters and displaying their details.
 */

namespace SalesTransactionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate SalesTransaction objects with different parameters
            SalesTransaction transaction1 = new SalesTransaction("Alice", 1000.00, 0.10); // Salesperson with name, sales amount, and commission rate
            SalesTransaction transaction2 = new SalesTransaction("Bob", 2000.00, 0.15);// Salesperson with name, sales amount, and commission rate
            SalesTransaction transaction3 = new SalesTransaction("Charlie", 1500.00);// Salesperson with name and sales amount, default commission rate of 0%
            SalesTransaction transaction4 = new SalesTransaction("David");// Salesperson with only name, default sales amount and commission rate
            SalesTransaction transaction5 = new SalesTransaction("Eve", 500.00, 0.05);// Salesperson with name, sales amount, and commission rate
            SalesTransaction transaction6 = new SalesTransaction("Frank", 3000.00);// Salesperson with name and sales amount, default commission rate of 0%
            SalesTransaction transaction7 = new SalesTransaction("Grace");// Salesperson with only name, default sales amount and commission rate

            // Header for the output
            Console.WriteLine("Sales Transactions Summary:");

            // Display the details of each transaction
            Console.WriteLine($"Salesperson: {transaction1.SalesPersonName}\nSales Amount: {transaction1.SalesAmount:C}\nCommission: {transaction1.Commission:C}");
            Console.WriteLine("--------------------------------------------------");// Display a separator line
            Console.WriteLine($"Salesperson: {transaction2.SalesPersonName}\nSales Amount: {transaction2.SalesAmount:C}\nCommission: {transaction2.Commission:C}");
            Console.WriteLine("--------------------------------------------------");// Display a separator line
            Console.WriteLine($"Salesperson: {transaction3.SalesPersonName}\nSales Amount: {transaction3.SalesAmount:C}\nCommission: {transaction3.Commission:C}");
            Console.WriteLine("--------------------------------------------------");// Display a separator line
            Console.WriteLine($"Salesperson: {transaction4.SalesPersonName}\nSales Amount: {transaction4.SalesAmount:C}\nCommission: {transaction4.Commission:C}");
            Console.WriteLine("--------------------------------------------------");// Display a separator line
            Console.WriteLine($"Salesperson: {transaction5.SalesPersonName}\nSales Amount: {transaction5.SalesAmount:C}\nCommission: {transaction5.Commission:C}");
            Console.WriteLine("--------------------------------------------------");// Display a separator line
            Console.WriteLine($"Salesperson: {transaction6.SalesPersonName}\nSales Amount: {transaction6.SalesAmount:C}\nCommission: {transaction6.Commission:C}");
            Console.WriteLine("--------------------------------------------------");// Display a separator line
            Console.WriteLine($"Salesperson: {transaction7.SalesPersonName}\nSales Amount: {transaction7.SalesAmount:C}\nCommission: {transaction7.Commission:C}");
        }
    }
}
