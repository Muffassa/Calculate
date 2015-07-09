using Calculator.SortingOfMassivs;
using NUnit.Framework;

namespace Calculator.Tests.SortingOfArrays
{
    [TestFixture]
    public abstract class AbstractSortTests
    {
        protected ISorter Sorter;

        [TestCase(new [] { 12, -3, 0.0 }, new [] { -3, 0.0, 12 })]
        [TestCase(new [] {0,1.2,2,3.1,4}, new []{0,1.2,2,3.1,4})]
        [TestCase(new []{7.2,5,3,2.1,0}, new[]{0,2.1,3,5, 7.2})]
        [TestCase(new []{0, 1.2, 1.2, 3, 5, -3.2}, new []{-3.2, 0, 1.2, 1.2, 3 , 5})]
        [TestCase(new []{0, 2.1 , -2, 3.1, 4, -2, -3.2, 12, 17, 32, 14, -11, 21, 12}, new[]{-11, -3.2, -2, -2, 0, 2.1, 3.1, 4, 12, 12, 14,17, 21, 32})]
        public void Sort(double[] argument, double[] result)
        {
            var testResult = Sorter.Sort(argument);
            Assert.AreEqual(result, testResult);
        }
    }
}
