using Calculator.SortingOfArrays;

namespace Calculator.SortingOfArrays
{
    public class GnomeSort:ISorter
    {
        /// <summary>
        /// Function for sorting array by gnome method
        /// </summary>
        /// <param name="a">calculate array</param>
        /// <returns>sorted array</returns>
        public double[] Sort(double[] a)
        {
            int i = 1;
            int j = 2;

            while (i < a.Length)
            {
                if (a[i - 1] <= a[i])
                {
                    i = j;
                    j++;
                }
                else
                {
                    double tmp = a[i - 1];
                    a[i - 1] = a[i];
                    a[i] = tmp;
                    i -= 1;
                    if (i != 0) continue;
                    i = 1;
                    j = 2;
                }
            }
            return a;
        }
    }
}
