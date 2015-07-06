using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
                double firstArgument = Convert.ToDouble(FirstArgument.Text);
                double secondArgument = Convert.ToDouble(SecondArgument.Text);

                double result = firstArgument*secondArgument;

                Result.Text = Convert.ToString(result);
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            
            double firstArgument = Convert.ToDouble(FirstArgument.Text),
                secondArgument = Convert.ToDouble(SecondArgument.Text);

            double result = firstArgument / secondArgument;

            Result.Text = Convert.ToString(result);
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            double firstArgument, secondArgument;
            if (double.TryParse(FirstArgument.Text, out firstArgument) &&
                double.TryParse(SecondArgument.Text, out secondArgument))
            {
                Result.Text = Convert.ToString(firstArgument + secondArgument);
            }
            Result.Text = "Error";
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            double firstArgument = Double.Parse(FirstArgument.Text),
                secondArgument = Double.Parse(SecondArgument.Text);

            Result.Text = Convert.ToString(firstArgument - secondArgument);
        }
    }
}
