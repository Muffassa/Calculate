using Calculator.SortingOfArrays;
using NUnit.Framework;

namespace CalculatorTests.SortingOfArrays
{
    [TestFixture]
    public class InsertionSortTests : AbstractSortTests
    {
        [SetUp]
        public void Initialize()
        {
            Sorter = new InsertionSort();
        }
    }
}
