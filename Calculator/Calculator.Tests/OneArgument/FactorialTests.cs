using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTests.OneArgument
{
    [TestFixture]
    class FactorialTests
    {
        [TestCase(2, 2)]
        [TestCase(0, 1)]
        public void Calculate(double argument, double result)
        {
            var calculator = new Factorial();
            var testResult = calculator.Calculate(argument);
            Assert.AreEqual(result, testResult);
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void FactorialTestsByNegative()
        {
            var calculator = new Factorial();
            var result = calculator.Calculate(-4);
        }
    }
}
