using Calculator.SortingOfMassivs;
using NUnit.Framework;

namespace Calculator.Tests.SortinfOfMassivs
{
    [TestFixture]
    class InsertionSortTests
    {
        
        [TestCase(new double [] {12, -3, 0}, new double [] {-3,0,12})]
        public void Calculate(double[] argument, double[] result)
        {
            var sort = new InsertionSort();
            var testResult = sort.Sort(argument);
            Assert.AreEqual(result, testResult);
        }
    }
}
