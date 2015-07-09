using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    class SubtractionTests
    {
        [TestCase(12, 4, 8)]
        [TestCase(-12, -2, -10)]
        [TestCase(4, -8, 12)]
        public void Calculate(double firstArgument, double secondArgument, double result)
        {
            var calculator = new Subtraction();
            var testResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, testResult);
        }
    }
}
