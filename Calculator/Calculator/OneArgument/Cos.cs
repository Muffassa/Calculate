using System;

namespace Calculator.OneArgument
{
    class Cos : IOperation
    {
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}