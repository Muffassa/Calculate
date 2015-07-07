using System;
using System.Windows.Forms;

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

        private void Calculate(object sender, EventArgs e)
        {
            double firstArgument = StringToDouble(FirstArgument.Text);
            double secondArgument = StringToDouble(SecondArgument.Text);

            double result;
            switch (((Button) sender).Name)
            {
                case "Sum":
                    result = firstArgument + secondArgument;
                    break;

                case "Subtraction":
                    result = firstArgument - secondArgument;
                    break;

                case "Multiplication":
                    result = firstArgument*secondArgument;
                    break;

                case "Division":
                    if (secondArgument == 0)
                    {
                        throw new Exception("Devision by zero");
                    }

                    result = firstArgument/secondArgument;
                    break;

                default:
                    throw new Exception("Unknown operation");
            }

            Result.Text = Convert.ToString(result);
        }

        private void CalculateSingleArgument(object sender, EventArgs e)
        {
            double firstArgument = StringToDouble(FirstArgument.Text);

            double result;
            switch (((Button)sender).Name)
            {
                case "Sin":
                    result = Math.Sin(firstArgument);
                    break;

                case "Abs":
                    result = Math.Abs(firstArgument);
                    break;

                default:
                    throw new Exception("Unknown operation");
            }

            Result.Text = Convert.ToString(result);
        }
    }
}

