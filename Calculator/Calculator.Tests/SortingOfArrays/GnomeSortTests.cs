using Calculator.SortingOfArrays;
using NUnit.Framework;

namespace Calculator.Tests.SortingOfArrays
{
    [TestFixture]
    class GnomeSortTests : AbstractSortTests
    {
        /// <summary>
        /// test of GnomeSort function
        /// </summary>
        [SetUp]
        public void Initialize()
        {
            Sorter = new GnomeSort();
        }
    }
}
