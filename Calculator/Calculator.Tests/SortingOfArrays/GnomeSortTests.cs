using Calculator.SortingOfMassivs;
using NUnit.Framework;

namespace Calculator.Tests.SortingOfArrays
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
