using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.SortingOfMassivs
{
   public class HeapSort:ISorter
    {
        public double[] Sort(double[] a)
        {
            int i;

            for (i = a.Length / 2 - 1; i >= 0; i--)
            {
                ShiftDown(a, i, a.Length);
            }

            for (i = a.Length - 1; i >= 1; i--)
            {
                var temp = a[0];
                a[0] = a[i];
                a[i] = temp;
                ShiftDown(a, 0, i);
            }

            return a;
        }

        static void ShiftDown(double[] a, int i, int j)
        {
            bool done = false;

            while ((i * 2 + 1 < j) && (!done))
            {
                int maxChild;
                if (i * 2 + 1 == j - 1)
                    maxChild = i * 2 + 1;
                else if (a[i * 2 + 1] > a[i * 2 + 2])
                    maxChild = i * 2 + 1;
                else
                    maxChild = i * 2 + 2;

                if (a[i] < a[maxChild])
                {
                    var temp = a[i];
                    a[i] = a[maxChild];
                    a[maxChild] = temp;
                    i = maxChild;
                }
                else
                {
                    done = true;
                }
            }
        }
    }
}
