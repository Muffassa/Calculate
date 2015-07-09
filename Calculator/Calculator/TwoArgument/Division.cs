using System;

namespace Calculator.TwoArgument
{
   public class Division : IOperation
    {
        /// <summary>
        /// Function calculation quotient of arguments
        /// </summary>
        /// <param name="firstArgument">dividend</param>
        /// <param name="secondArgument">	divisor</param>
        /// <returns>quotient</returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
              throw new Exception("Division by zero");
            }
            else
            {
                return firstArgument / secondArgument;
            }
        }
    }
}