namespace Calculator.TwoArgument
{
   public class Multiplication : IOperation
    {
       /// <summary>
        /// Function for computation cup product of two arguments
       /// </summary>
       /// <param name="firstArgument">first argument of computation</param>
       /// <param name="secondArgument">secont argument of computation</param>
       /// <returns>cup product</returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }
    }
}
