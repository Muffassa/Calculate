using System;

namespace Calculator.TwoArgument
{
   public static class TwoArgumentFactory
    {
        public static IOperation CreateCalculator(string operation)
        {
            switch (operation)
            {
                case "Sum":
                    return new Sum();
                case "Division":
                    return new Division();
                case "Multiplication":
                    return new Multiplication();
                case "Subtraction":
                    return new Subtraction();
                case "Pow":
                    return  new Pow();
                default: throw new Exception("Unknown operation");
            }
        }
    }
}
