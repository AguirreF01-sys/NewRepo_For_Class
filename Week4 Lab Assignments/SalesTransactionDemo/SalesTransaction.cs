/* Florentino Aguirre
 * CPSC 23000 .NET Programming
 * Week 4 Lab Assignment
 * SalesTransaction.cs
 * This code defines a SalesTransaction class with properties for sales person name, sales amount, and commission.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTransactionDemo
{
    internal class SalesTransaction
    {
        //Variables
        public string salesPersonName;
        private double salesAmount;
        private double commission;
        private double commissionRate;

        /*********Setters and Getters*********/
public string SalesPersonName
        {
            get { return salesPersonName; }
            set { salesPersonName = value; }
        }

        public double SalesAmount
        {
            get { return salesAmount; }
            set { salesAmount = value; }
        }
        public double Commission
        {
            get { return commission; }
            set { commission = value; }
        }

        /***********Overloaded**************/
        /**********Constructors**************/
        public SalesTransaction(string salesPersonName, double salesAmount, double commissionRate)// Constructor with all parameters
        {
            this.salesPersonName = salesPersonName;
            this.salesAmount = salesAmount;
            this.commission= salesAmount * commissionRate;
        }

        public SalesTransaction(string salesPersonName, double salesAmount) // Constructor with salesPersonName and salesAmount, default commissionRate of 0%
        {
            this.salesPersonName = salesPersonName;
            this.salesAmount = salesAmount;
            this.commissionRate = 0.00; // Default commission rate of 0%
            this.commission = salesAmount * commissionRate;
        }

        public SalesTransaction(string salesPersonName)// Constructor with only salesPersonName, default salesAmount and commissionRate
        {
            this.salesPersonName = salesPersonName;
            this.salesAmount = 0.00;
            this.commissionRate = 0.00; // Default commission rate of 0%
            this.commission = 0.00;
        }

    }
}
