using System;

namespace Calculator.OneArgument
{
   public class Absolute : IOperation
    {
        public double Calculate(double firstArgument)
        {
            return Math.Abs(firstArgument);
        }
    }
}
