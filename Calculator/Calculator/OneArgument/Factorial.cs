using System;

namespace Calculator.OneArgument
{
    public class Factorial : IOperation
    {
        /// <summary>
        /// Function for calculating factorial of argument
        /// </summary>
        /// <param name="firstArgument">argument of calculating</param>
        /// <returns>result of calculating factorial of argument</returns>
        public double Calculate(double firstArgument)
        {
            if (firstArgument < 0)
            {
                throw new Exception("Cant use argument < 0");
            }
            else
            {
                double result = 1;
                for (var i = 1; i < firstArgument; i++)
                {
                    result *= i + 1;
                }
                return result;
            }
        }
    }
}
