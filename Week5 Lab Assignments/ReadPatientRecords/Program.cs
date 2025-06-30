using System.Globalization;
using System.IO;
using System;


namespace ReadPatientRecords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string fileName = "patients.txt";

            if (!File.Exists(fileName))
            {
                Console.WriteLine($"Error: File '{fileName}' not found.");
                return;
            }

            var patients = new List<Patient>();

            try
            {
                using (var reader = new StreamReader(fileName))
                {
                    // Skip header
                    reader.ReadLine();

                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(',');
                        if (parts.Length != 3)
                        {
                            Console.WriteLine($"Skipping malformed line: {line}");
                            continue;
                        }

                        if (!int.TryParse(parts[0], out int id))
                        {
                            Console.WriteLine($"Invalid ID in line: {line}");
                            continue;
                        }

                        var name = parts[1];

                        if (!decimal.TryParse(parts[2],
                                NumberStyles.Any,
                                CultureInfo.InvariantCulture,
                                out decimal balance))
                        {
                            Console.WriteLine($"Invalid balance in line: {line}");
                            continue;
                        }

                        patients.Add(new Patient(id, name, balance));
                    }
                }

                Console.WriteLine($"\nLoaded {patients.Count} record(s):\n");
                foreach (var p in patients)
                {
                    Console.WriteLine(p);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }

        }
    }
}
