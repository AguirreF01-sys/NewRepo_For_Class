/* Florentino Aguirre
 * CPSC 23000 .NET Programming
 * Week 3 Lab Assignment
 * Eggs Interactive GUI
 * This program calculates the total number of eggs from five chickens
 */

namespace EggsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            //Variables to hold the number of eggs from each chicken
            int chicken1 = (int)numericUpDown1.Value;
            int chicken2 = (int)numericUpDown2.Value;
            int chicken3 = (int)numericUpDown3.Value;
            int chicken4 = (int)numericUpDown4.Value;
            int chicken5 = (int)numericUpDown5.Value;

            //Calculate the total number of eggs, dozens, and remaining eggs
            int totalEggs = chicken1 + chicken2 + chicken3 + chicken4 + chicken5;
            int dozenEggs = totalEggs / 12;
            int remainingEggs = totalEggs % 12;

            //Display the results in the label
            if (totalEggs > 0)
            {
                label7.Text = $"A total of {totalEggs} eggs is {dozenEggs} dozen and {remainingEggs} eggs.";
            }
            else
            {
                label7.Text = "Total Eggs: 0";

            }
        }
    }
}
