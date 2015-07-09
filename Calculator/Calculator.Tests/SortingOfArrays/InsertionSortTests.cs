using Calculator.SortingOfArrays;
using NUnit.Framework;

namespace Calculator.Tests.SortingOfArrays
{
    [TestFixture]
    public class InsertionSortTests : AbstractSortTests
    {
        /// <summary>
        /// test of InsertionSort function
        /// </summary>
        [SetUp]
        public void Initialize()
        {
            Sorter = new InsertionSort();
        }
    }
}
