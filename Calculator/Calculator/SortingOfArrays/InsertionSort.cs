using Calculator.SortingOfArrays;

namespace Calculator.SortingOfArrays
{
    /// <summary>
    /// Function for sorting array by insertion method
    /// </summary>
    /// <param name="a">calculate array</param>
    /// <returns>sorted array</returns>
    public class InsertionSort : ISorter
    {
        public double[] Sort(double[] a)
        {
            {
                int i, j;

                for (i = 1; i < a.Length; i++)
                {
                    var value = a[i];
                    for (j = i - 1; j >= 0 && a[j] > value; j--)
                    {
                        a[j + 1] = a[j];
                    }
                    a[j + 1] = value;
                }
            }
            return a;
        }
    }
}