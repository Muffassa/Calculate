namespace Calculator.SortingOfMassivs
{
    public class BubbleSort : ISorter
    {
        public double[] Sort (double[] a)
        {
            for (int j = 0; j < a.Length - 1; j++)
            {
                for (int i = 0; i < a.Length - j - 1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        double b = a[i]; //change for elements
                        a[i] = a[i + 1];
                        a[i + 1] = b;
                    }
                }
            }
            return a;
        }
    }
}
