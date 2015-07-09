using Calculator.SortingOfArrays;
using Calculator.SortingOfArrays;
using NUnit.Framework;

namespace CalculatorTests.SortingOfArrays
{
    [TestFixture]
    class GnomeSortTests : AbstractSortTests
    {
        [SetUp]
        public void Initialize()
        {
            Sorter = new GnomeSort();
        }
    }
}
