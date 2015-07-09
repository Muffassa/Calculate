using System;

namespace Calculator.OneArgument
{
    public class Cos : IOperation
    {   
        /// <summary>
        /// Function for calculating cos of argument
        /// </summary>
        /// <param name="firstArgument">argument of calculating</param>
        /// <returns>result of calculating cos of argument</returns>
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}