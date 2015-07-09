using System;

namespace Calculator.TwoArgument
{
   public class Pow: IOperation
    {
       /// <summary>
        /// Function for computation number in something  quotient
       /// </summary>
       /// <param name="Argument">number</param>
        /// <param name="degree">quotient of number</param>
       /// <returns>number in quotient</returns>
        public double Calculate(double Argument, double degree)
        {
            return Math.Pow(Argument, degree);
        }
    }
}
