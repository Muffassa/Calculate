using Calculator.SortingOfArrays;
using NUnit.Framework;

namespace Calculator.Tests.SortingOfArrays
{
    [TestFixture]
    class HeapSortTests : AbstractSortTests
    {
        /// <summary>
        /// test of HeapSort function
        /// </summary>
        [SetUp]
        public void Initialize()
        {
            Sorter = new HeapSort();
        }
    }
}
