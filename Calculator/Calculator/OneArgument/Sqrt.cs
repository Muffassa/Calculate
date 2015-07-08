using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OneArgument
{
    public class Sqrt: IOperation
    {
        public double Calculate(double argument)
        {
            if (argument <= 0)
            {
                throw new Exception("sqrt by zero");
            }
            else
            {
                return Math.Sqrt(argument);
            }

        }
    }
}
