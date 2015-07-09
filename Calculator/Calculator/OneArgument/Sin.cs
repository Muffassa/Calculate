using System;

namespace Calculator.OneArgument
{
  public  class Sin:IOperation
    {
      /// <summary>
      /// Function for calculatin sin of argument 
      /// </summary>
      /// <param name="firstArgument">calculating argument</param>
      /// <returns>sin of argument</returns>
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}