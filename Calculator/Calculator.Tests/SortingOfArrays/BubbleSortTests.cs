using Calculator.SortingOfArrays;
using NUnit.Framework;

namespace Calculator.Tests.SortingOfArrays
{
    class BubbleSortTests : AbstractSortTests
    {
        /// <summary>
        /// test of bubbleSort function
        /// </summary>
        [SetUp]
        public void Initialize()
        {
            Sorter = new BubbleSort();
        }
    }
}
