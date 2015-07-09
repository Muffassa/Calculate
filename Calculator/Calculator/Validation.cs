using System;

namespace Calculator
{
    public  static class Validation
    {
        /// <summary>
        /// Function is redifining param text(type string) to result(type double and checking is valid text or not  
        /// </summary>
        /// <param name="text">inputed text</param>
        /// <returns name = "result">valid text(type double)</returns>
        public static double StringToDouble(string text)
        {
            double result;
            if (!double.TryParse(text, out result))
            {
                 throw new Exception("Non Valid argument");
            }
            return result;
        }
    }
}
