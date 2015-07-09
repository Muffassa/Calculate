using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{

    [TestFixture]
    class MultiplicationTests
    {
        /// <summary>
        /// Test of Multiplication function
        /// </summary>
        /// <param name="firstArgument">first argument of multiplication</param>
        /// <param name="secondArgument">second argument of multiplication</param>
        /// <param name="result">expected cup product</param>
        [TestCase(10, 2, 20)]
        [TestCase(7, 2, 14)]
        [TestCase(-7, 2, -14)]
        [TestCase(0, 10, 0)]
        public void Calculate(double firstArgument, double secondArgument, double result)
        {
            var calculator = new Multiplication();
            var testResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, testResult);
        }
    }
}