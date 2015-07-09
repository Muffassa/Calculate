namespace Calculator.TwoArgument
{
   public class Subtraction:IOperation
    {
       /// <summary>
        /// Function for computation differenc of two arguments
       /// </summary>
        /// <param name="firstArgument">argument whereof takeing</param>
       /// <param name="secondArgument">argument which taking</param>
       /// <returns>differenc of firstArgument and secondArgument</returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
                return firstArgument - secondArgument;
        }
    }
}
