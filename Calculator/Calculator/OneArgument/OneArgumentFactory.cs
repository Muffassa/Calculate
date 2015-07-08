using System;

namespace Calculator.OneArgument
{
    public static class OneArgumentFactory
    {
        public static IOperation CreateCalculator(string operation)
        {
            switch (operation)
            {
                case "Sin": 
                    return new Sin();
                case "Cos":
                    return new Cos();
                case "Abs": 
                    return new Absolute();
                case "Sqrt":
                    return new Sqrt();
                case "Factorial":
                    return new Factorial();
                default: throw new Exception("Unknown operation");
            }
        }
    }
}
