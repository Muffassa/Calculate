using System;

namespace Calculator.OneArgument
{
    public class Sqrt : IOperation
    {
        /// <summary>
        /// Function for calculation  square root of argument
        /// </summary>
        /// <param name="argument">calculating argument</param>
        /// <returns>square root of argument</returns>
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
