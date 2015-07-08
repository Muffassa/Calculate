using System;

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
                case "GnomeSort":
                    return new GnomeSort();
                case "BubbleSort":
                    return new BubbleSort();
                case "InsertionSort":
                    return new InsertionSort();
                default:
                    throw new Exception("Unknown operation");
            }
        }
    }
}
