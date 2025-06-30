/* Florentino Aguirre
 * CPSC 23000 .NET Programming
 * Week 5 Lab Assignment
 * Write Patient Records
 * This program collects patient information and writes it to a CSV file.
 */

namespace WritePatientRecords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate a list to hold patient records
            var patients = new List<Patient>();

            // Prompt user for patient information
            Console.WriteLine("Enter patient information. To finish, enter -1 for the patient ID.");
            while (true)
            {
                // Read patient ID, name, and balance
                Console.Write("Patient ID: ");
                string idInput = Console.ReadLine();
                if (!int.TryParse(idInput, out int id) || id == -1)
                    break;

                Console.Write("Patient Name: ");
                string name = Console.ReadLine();

                Console.Write("Current Balance Owed: ");
                string balInput = Console.ReadLine();

                // Validate balance input
                if (!decimal.TryParse(balInput, out decimal balance))
                {
                    Console.WriteLine("  >> Invalid balance; please enter a number (e.g. 123.45).");
                    continue;
                }

                // Create a new Patient object and add it to the list
                patients.Add(new Patient(id, name, balance));
                // Confirm addition of patient message
                Console.WriteLine("  >> Patient added.\n");
            }

            // If no patients were added, exit the program
            if (patients.Count == 0)
            {
                Console.WriteLine("No patient records to save. Exiting.");
                return;
            }
            // Confirm number of patients added
            string fileName = "patients.txt";

            // Write the patient records to a file
            try
            {
                // Open the file for writing
                using (var writer = new StreamWriter(fileName))
                {
                    // Write CSV header
                    writer.WriteLine("Id,Name,Balance");
                    // Write each patient as a CSV line
                    foreach (var p in patients)
                        writer.WriteLine($"{p.Id},{p.Name},{p.Balance}");
                }

                // Confirm successful write
                Console.WriteLine($"\nSuccessfully wrote {patients.Count} records to '{fileName}'.");
            }

            // Handle any exceptions that occur during file writing
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing file: {ex.Message}");
            }

        }
    }
}
