using System;
using Calculator.TwoArgument;
using NUnit.Framework;

namespace CalculatorTests.TwoArguments
{

    [TestFixture]
    class DivisionTests
    {
        [TestCase(10, 2, 5)]
        [TestCase(7, 2, 3.5)]
        [TestCase(-10, 2, -5)]
        [TestCase(1, 10, 0.1)]
        public void Calculate(double firstArgument, double secondArgument, double result)
        {
            var calculator = new Division();
            var testResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, testResult);
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void DivisionByZeroTests()
        {
            var calculator = new Division();
            var result = calculator.Calculate(4, 0);
        }
    }
}