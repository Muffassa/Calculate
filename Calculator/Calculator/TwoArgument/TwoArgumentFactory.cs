using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.TwoArgument
{
    class TwoArgumentFactory
    {
        public static IOperation CreateCalculator(string operation)
        {
            switch (operation)
            {
                case "Sum":
                    return new Sum();
                    break;
                case "Division":
                    return new Division();
                    break;
                case "Multiplication":
                    return new Multiplication();
                    break;
                case "Subtraction":
                    return new Subtraction();
                    break;
                default: throw new Exception("Unknown operation");
            }
        }
    }
}
