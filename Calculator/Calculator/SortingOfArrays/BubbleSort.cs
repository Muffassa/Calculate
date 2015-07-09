using Calculator.SortingOfArrays;

namespace Calculator.SortingOfArrays
{
    public class BubbleSort : ISorter
    {
        /// <summary>
        /// Function for sorting array by bubble method
        /// </summary>
        /// <param name="a">calculate array</param>
        /// <returns>sorted array</returns>
        public double[] Sort (double[] a)
        {
            for (var j = 0; j < a.Length - 1; j++)
            {
                for (var i = 0; i < a.Length - j - 1; i++)
                {
                    if (!(a[i] > a[i + 1])) continue;
                    var b = a[i]; //change for elements
                    a[i] = a[i + 1];
                    a[i + 1] = b;
                }
            }
            return a;
        }
    }
}
