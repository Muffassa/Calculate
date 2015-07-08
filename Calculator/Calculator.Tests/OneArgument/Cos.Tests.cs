using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.OneArgument;
using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    class CosTests
    {
        [TestCase(0, 1)]
        public void Calculate(double argument, double result)
        {
            var calculator = new Cos();
            var testResult = calculator.Calculate(argument);
            Assert.AreEqual(result, testResult);
        }
    }
}
