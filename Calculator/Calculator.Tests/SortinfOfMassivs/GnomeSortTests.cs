using NUnit.Framework;
using Calculator.SortingOfMassivs;

namespace Calculator.Tests.SortinfOfMassivs
{
    [TestFixture]
    class GnomeSortTests
    {

        [TestCase(new double[] { 12, -3, 0 }, new double[] { -3, 0, 12 })]
        public void Calculate(double[] argument, double[] result)
        {
            var sort = new GnomeSort();
            var testResult = sort.Sort(argument);
            Assert.AreEqual(result, testResult);
        }
    }
}
