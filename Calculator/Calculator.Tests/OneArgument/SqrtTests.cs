using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    class SqrtTests
    {
        /// <summary>
        /// Test for operation Sqrt for one argument
        /// </summary>
        /// <param name="argument">argument which we will calculate sqrt </param>
        [TestCase(9)]
        [TestCase(25)]
        [TestCase(16)]
        [TestCase(4)]
        public void Calculate(double argument)
        {
            var calculator = new Sqrt();
            var testResult = calculator.Calculate(argument);
            var result = Math.Sqrt(argument);
            Assert.AreEqual(testResult,result);
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void SqrtTestsByNegative()
        {
            var calculator = new Sqrt();
            var result = calculator.Calculate(-4);
        }
    }
}

