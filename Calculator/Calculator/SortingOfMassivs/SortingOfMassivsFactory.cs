using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.SortingOfMassivs
{
    static class SortingOfMassivsFactory
    {
        public static ISorter CreateSorting(string operation)
        {
            switch (operation)
            {
                case "HeapSort":
                    return new HeapSort();
                    break;
                case "GnomeSort":
                    return new GnomeSort();
                    break;
                default:
                    throw new Exception("Unknown operation");
            }
        }
    }
}
