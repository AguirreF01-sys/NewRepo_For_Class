/* Florentino Aguirre
 * CPSC 23000 .NET Programming
 * Week 3 Lab Assignment
 * Make Change GUI
 * This program takes a dollar amount as input and calculates the number of each denomination needed to make that amount.
 */

using System.Windows.Forms;

namespace MakeChangeGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Ensure that the input is a valid integer
            int value = textBox1.Text.Length > 0 ? int.Parse(textBox1.Text) : 0;

            // variables to hold the number of each denomination
            int numOfHundreds = value / 100;
            int numOfFifties = (value % 100) / 50;
            int numOfTwenties = (value % 50) / 20;
            int numOfTens = (value % 20) / 10;
            int numOfFives = (value % 10) / 5;
            int numOfOnes = value % 5;

            // Display the results in label3
            label3.Text = $"${value} is {numOfHundreds} hundreds, {numOfFifties} fifties, {numOfTwenties} twenties, {numOfTens} tens, {numOfFives} fives, {numOfOnes} ones.";
        }
    }
}
