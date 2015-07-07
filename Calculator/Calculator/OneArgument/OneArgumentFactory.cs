using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OneArgument
{
    class OneArgumentFactory
    {
        public static IOperation CreateCalculator(string operation)
        {
            switch (operation)
            {
                case "Sin": 
                    return new Sin();
                    break;
                case "Abs": 
                    return new Absolute();
                    break;
                default: throw new Exception("Unknown operation");
            }
        }
    }
}
