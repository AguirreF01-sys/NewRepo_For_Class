/* Florentino Aguirre
 * CPSC 23000 .NET Programming
 * Week 3 Lab Assignment
 * Projected Raises GUI
 * This program calculates a projected raise based on a user input salary.
 */


namespace ProjectedRaisesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //this method takes the user input from textBox1, calculates a 4% raise, and displays it in textBox2
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // variable to hold the salary input
            int salary;
            // Attempt to parse the input from textBox1
            if (int.TryParse(textBox1.Text, out salary) && salary > 0)
            {
                // If parsing is successful and salary is positive, calculate the projected raise
                double projectedRaise = salary+(salary * 0.04); // 4% raise
                textBox2.Text = projectedRaise.ToString("C"); // Format as currency
            }
            // If parsing fails or salary is not positive, display an error message
            else
            {
                textBox2.Text = "Invalid input"; // Handle invalid input
            }
        }
    }
}
