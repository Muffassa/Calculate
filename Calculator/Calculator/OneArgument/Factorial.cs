using System;

namespace Calculator.OneArgument
{
    public class Factorial : IOperation
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument < 0)
            {
                throw new Exception("Cant use argument < 0");
            }
            else
            {
                double result = 1;
                for (int i = 1; i < firstArgument; i++)
                {
                    result *= i + 1;
                }
                return result;
            }
        }
    }
}
