using System;

namespace Calculator.OneArgument
{
    public class Sqrt : IOperation
    {
        public double Calculate(double argument)
        {
            if (argument <= 0)
            {
                throw new Exception("sqrt by zero");
            }
            return Math.Sqrt(argument);
        }
    }
}
