using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    class FactorialTests
    {
        /// <summary>
        /// test for method factorial
        /// </summary>
        /// <param name="argument">argument of operation</param>
        /// <param name="result">expceted factorial of argument</param>
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
