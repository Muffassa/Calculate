using Calculator.SortingOfMassivs;
using NUnit.Framework;

namespace Calculator.Tests.SortinfOfMassivs
{
    [TestFixture]
    class HeapSortTests
    {

        [TestCase(new double[] { 12, -3, 0 }, new double[] { -3, 0, 12 })]
        public void Calculate(double[] argument, double[] result)
        {
            var sort = new HeapSort();
            var testResult = sort.Sort(argument);
            Assert.AreEqual(result, testResult);
        }
    }
}
