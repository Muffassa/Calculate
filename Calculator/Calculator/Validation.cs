using System;

namespace Calculator
{
    public  static class Validation
    {
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
