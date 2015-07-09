using Calculator.TwoArgument;
using NUnit.Framework;

namespace CalculatorTests.TwoArguments
{
    
    [TestFixture]
    class SumTests
    {
        [TestCase( 5, 5, 10)]
        [TestCase(-5, 2, -3)]
        [TestCase(-4, -8, -12)]
        public void Calculate(double firstArgument, double secondArgument, double result)
        {
            var calculator = new Sum();
            var testResult = calculator.Calculate(firstArgument,secondArgument);
            Assert.AreEqual(result,testResult);
        }
    }
}

