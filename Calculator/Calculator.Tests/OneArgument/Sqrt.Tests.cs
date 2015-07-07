using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.OneArgument;
using NUnit.Framework;


namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    class SqrtTests
    {
        [Test]
        public void Calculate()
        {
            var calculator = new Sqrt();
            var testResult = calculator.Calculate(124);
            var result = Math.Sqrt(124);
            Assert.AreEqual(testResult,result);
        }
    }
}
