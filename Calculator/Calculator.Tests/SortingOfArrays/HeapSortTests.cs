using Calculator.SortingOfArrays;
using NUnit.Framework;

namespace CalculatorTests.SortingOfArrays
{
    [TestFixture]
    class HeapSortTests : AbstractSortTests
    {
        [SetUp]
        public void Initialize()
        {
            Sorter = new HeapSort();
        }
    }
}
