using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    break;
                case "Cos":
                    return new Cos();
                    break;
                case "Abs": 
                    return new Absolute();
                    break;
                case "Sqrt":
                    return new Sqrt();
                    break;
                case "Factorial":
                    return new Factorial();
                    break;
                default: throw new Exception("Unknown operation");
            }
        }
    }
}
