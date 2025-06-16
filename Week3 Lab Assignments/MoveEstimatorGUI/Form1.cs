/* Florentino Aguirre
 * CPSC 23000 .NET Programming
 * Week 3 Lab Assignment
 * Moving Cost Estimator
 * This program estimates the cost of moving based on miles and hours.
 */


namespace MoveEstimatorGUI
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // variables to hold the input values
            int miles;
            int hours;

            // Attempt to parse the input from text boxes
            if (int.TryParse(textBox1.Text, out miles) && int.TryParse(textBox2.Text, out hours))
            {
                // calculate the estimated cost
                double costEstimate = (double)((miles*2) + (hours*150) + 200);
                // display the result in label5
                label5.Text = "Estimated Cost: $" + costEstimate.ToString("F2");
            }
            else
            {
                // Show an error message if input is invalid
                MessageBox.Show("Please enter valid numbers for miles and hours.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
