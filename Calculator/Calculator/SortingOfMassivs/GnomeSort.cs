using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.SortingOfMassivs
{
    class GnomeSort:ISorter
    {
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
                    if (i == 0)
                    {
                        i = 1;
                        j = 2;
                    }
                }
            }
            return a;
        }
    }
}
