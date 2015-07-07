using System;

namespace Calculator.OneArgument
{
    class Absolute : IOperation
    {
        public double Calculate(double firstArgument)
        {
            return Math.Abs(firstArgument);
        }
    }
}
