using System;

namespace Calculator.OneArgument
{
    public class Cos : IOperation
    {
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}