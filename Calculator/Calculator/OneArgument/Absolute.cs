using System;

namespace Calculator.OneArgument
{
   public class Absolute : IOperation
    {
       /// <summary>
       /// Function calculation absolute of argument
       /// </summary>
       /// <param name="firstArgument">argument of calculation</param>
       /// <returns>Absolute of argument</returns>
        public double Calculate(double firstArgument)
        {
            return Math.Abs(firstArgument);
        }
    }
}
