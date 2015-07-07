using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.TwoArgument
{
    class Pow: IOperation
    {
        public double Calculate(double Argument, double degree)
        {
            return Math.Pow(Argument, degree);
        }
    }
}
