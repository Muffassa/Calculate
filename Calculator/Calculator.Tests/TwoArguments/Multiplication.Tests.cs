using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Tests
{

    [TestFixture]
    class MultiplicationTests
    {
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