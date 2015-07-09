using Calculator.SortingOfArrays;
using Calculator.SortingOfArrays;
using NUnit.Framework;

namespace CalculatorTests.SortingOfArrays
{
    class BubbleSortTests : AbstractSortTests
    {

        [SetUp]
        public void Initialize()
        {
            Sorter = new BubbleSort();
        }
    }
}
