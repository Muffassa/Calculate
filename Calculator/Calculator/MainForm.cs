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

        private void Calculate(object sender, EventArgs e)
        {
            double firstArgument, 
                secondArgument;
            if (double.TryParse(FirstArgument.Text, out firstArgument) &&
                double.TryParse(SecondArgument.Text, out secondArgument))
            {
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
                        result = firstArgument * secondArgument;
                        break;
                 
                    case "Division":
                        if (secondArgument == 0)
                        {
                            throw new Exception("Devision by zero");
                            
                        }

                        result = firstArgument/secondArgument;
                        break;

                    default: 
                        throw new Exception(); 
                }

                Result.Text = Convert.ToString(result);
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
