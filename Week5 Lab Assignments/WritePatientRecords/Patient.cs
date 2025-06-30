/* Florentino Aguirre
 * CPSC 23000 .NET Programming
 * Week 5 Lab Assignment
 * Patient Class
 * This class represents a patient with an ID, name, and balance.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WritePatientRecords
{
    internal class Patient
    {

        //setters and getters for the properties of the Patient class
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }

        // Constructor to initialize a new Patient object
        public Patient(int id, string name, decimal balance)
        {
            Id = id;
            Name = name;
            Balance = balance;
        }

    }
}
