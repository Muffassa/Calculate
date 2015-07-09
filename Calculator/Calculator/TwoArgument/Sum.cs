namespace Calculator.TwoArgument
{
    public class Sum : IOperation
    {
        /// <summary>
        /// Function for addition two arguments
        /// </summary>
        /// <param name="firstArgument">first argument of addition</param>
        /// <param name="secondArgument">second argument of addition</param>
        /// <returns>addition of first argument and second argument</returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}
        
