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

        
        private void ButtonMultiplicationClick(object sender, EventArgs e)
        {
            double firstArgument, secondArgument;
            if (double.TryParse(FirstArgument.Text, out firstArgument) &&
                double.TryParse(SecondArgument.Text, out secondArgument))
            {
                Result.Text = Convert.ToString(firstArgument * secondArgument);
            }
            else
                Result.Text = "Error";
        }

        private void ResultTextChanged(object sender, EventArgs e)
        {
            
        }

        private void ButtonDivisionClick(object sender, EventArgs e)
        {

            double firstArgument, secondArgument;
            if (double.TryParse(FirstArgument.Text, out firstArgument) &&
                double.TryParse(SecondArgument.Text, out secondArgument))
            {
                if(secondArgument != 0)
                {
                    Result.Text = Convert.ToString(firstArgument / secondArgument);
                }else Result.Text = "Error";
            }
            else Result.Text = "Error";
        }

        private void ButtonSumClick(object sender, EventArgs e)
        {
            double firstArgument, secondArgument;
            if (double.TryParse(FirstArgument.Text, out firstArgument) &&
                double.TryParse(SecondArgument.Text, out secondArgument))
            {
                Result.Text = Convert.ToString(firstArgument + secondArgument);
            }else
            Result.Text = "Error";
        }

        private void ButtonSubtractionClick(object sender, EventArgs e)
        {
            double firstArgument, secondArgument;
            if (double.TryParse(FirstArgument.Text, out firstArgument) &&
                double.TryParse(SecondArgument.Text, out secondArgument))
            {
                Result.Text = Convert.ToString(firstArgument - secondArgument);
            }else
            Result.Text = "Error";
        }
    }
}
