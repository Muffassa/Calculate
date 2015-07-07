using System;

namespace Calculator.OneArgument
{
    class Sin:IOperation
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}