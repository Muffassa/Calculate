using System;
using System.Windows.Forms;
using Calculator.TwoArgument;
using Calculator.OneArgument;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private double StringToDouble(string text)
        {
            return double.Parse(text);
        }

        private void CalculateTwoArgument(object sender, EventArgs e)
        {
            double firstArgument = StringToDouble(FirstArgument.Text);
            double secondArgument = StringToDouble(SecondArgument.Text);
            string operation = (((Button) sender).Name);
            var op = TwoArgumentFactory.CreateCalculator(operation);
            double result = op.Calculate(firstArgument, secondArgument);
            Result.Text = Convert.ToString(result);
        }

        private void CalculateOneArgument(object sender, EventArgs e)
        {
            double firstArgument = StringToDouble(FirstArgument.Text);
            string operation = (((Button)sender).Name);
            var op = OneArgumentFactory.CreateCalculator(operation);
            double result = op.Calculate(firstArgument);
            Result.Text = Convert.ToString(result);
        }
    }
}

