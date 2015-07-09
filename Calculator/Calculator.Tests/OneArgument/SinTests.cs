using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    class SinTests
    {
        [TestCase(0, 0)]
        public void Calculate(double argument, double result)
        {
            
            var calculator = new Sin();
            var testResult = calculator.Calculate(argument);
            Assert.AreEqual(result, testResult);
        }
    }
}
