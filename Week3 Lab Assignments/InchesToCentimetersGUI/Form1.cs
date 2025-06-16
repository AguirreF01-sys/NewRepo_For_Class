/* Florentino Aguirre
 * CPSC 23000 .NET Programming
 * Week 3 Lab Assignment
 * Inches to Centimeters Converter GUI Application with Button Click Event
 * This application converts inches to centimeters using a simple Windows Forms interface.
 */

namespace InchesToCentimetersGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate input
            double inches;
            // Check if the input is a valid double and assign it to inches variable
            inches = Convert.ToDouble(textBox1.Text);
            // multiply inches by 2.54 to convert to centimeters and assign the result to centimeters variable
            double centimeters = inches * 2.54;
            // Display the result in textBox2, formatted to 2 decimal places
            textBox2.Text = centimeters.ToString("F2"); // Format to 2 decimal places
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
