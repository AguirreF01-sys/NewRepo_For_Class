/* Florentino Aguirre
 * CPSC 23000 .NET Programming
 * Week 4 Lab Assignment
 * ClassifiedAd.cs
 * This class represents a classified ad with properties for category, description, and price.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassifiedAd
{
    internal class ClassifiedAd
    {
        // Variables
        public string category;     
        private string description;
        private double price;

        // Getters and Setters
        public string Category {
            get { return category; }
            set { category = value; } 
        }
        public string Description { 
            get; 
            set; 
        }
        public double Price {
            get { return price; }// Get for price
        }
        public int DescriptionWordCount{ 
            get { return description.Split(' ').Length; }// Get for word count for the description variable
        }

        // Constructor
        public ClassifiedAd(string category, string description, double price)
        {
            this.category = category;
            this.description = description;
            this.price = price;
        }

        // Override ToString method to display ad details
        override public string ToString()
        {
            return $"Category: {category}\nDescription: {description}";
        }
    }
}
