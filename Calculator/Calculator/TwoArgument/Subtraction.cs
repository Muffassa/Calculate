using System;

namespace Calculator.TwoArgument
{
   public class Subtraction:IOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
                return firstArgument - secondArgument;
        }
    }
}
