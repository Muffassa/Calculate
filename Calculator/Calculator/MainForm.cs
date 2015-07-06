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
            int firstArgument = Convert.ToInt32(FirstArgument.Text),
                secondArgument = Convert.ToInt32(SecondArgument.Text);

            int result = firstArgument*secondArgument;

            Result.Text = Convert.ToString(result);

        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            int firstArgument = Convert.ToInt32(FirstArgument.Text),
                secondArgument = Convert.ToInt32(SecondArgument.Text);

            int result = firstArgument / secondArgument;

            Result.Text = Convert.ToString(result);
        }
    }
}
