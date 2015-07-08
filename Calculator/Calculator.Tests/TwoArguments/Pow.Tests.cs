using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{

    [TestFixture]
    class PowTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(2, 5, 32)]
        [TestCase(10, 2, 100)]
        [TestCase(10, -2, 0.01)]
        public void Calculate(double firstArgument, double secondArgument, double result)
        {
            var calculator = new Pow();
            var testResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, testResult);
        }
    }
}