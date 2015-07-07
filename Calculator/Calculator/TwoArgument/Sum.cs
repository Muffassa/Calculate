namespace Calculator.TwoArgument
{
    public class Sum : IOperation
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}
        
