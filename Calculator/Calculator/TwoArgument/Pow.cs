using System;

namespace Calculator.TwoArgument
{
   public class Pow: IOperation
    {
        public double Calculate(double Argument, double degree)
        {
            return Math.Pow(Argument, degree);
        }
    }
}
