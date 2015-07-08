using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    class AbsouluteTests
    {

        [TestCase(-24, 24)]
        [TestCase(24, 24)]
        [TestCase(0, 0)]
        public void Calculate(double argument, double result)
        {
            var calculator = new Absolute();
            var testResult = calculator.Calculate(argument);
            Assert.AreEqual(result, testResult);
        }
    }
}
