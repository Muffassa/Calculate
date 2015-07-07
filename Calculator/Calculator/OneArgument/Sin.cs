using System;

namespace Calculator.OneArgument
{
  public  class Sin:IOperation
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}