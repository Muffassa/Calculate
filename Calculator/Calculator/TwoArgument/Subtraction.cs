using System;

namespace Calculator.TwoArgument
{
    class Subtraction:IOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
                return firstArgument - secondArgument;
        }
    }
}
