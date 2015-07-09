using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{

    [TestFixture]
    class PowTests
    {
        /// <summary>
        /// Test Function for computation number in something  quotient
        /// </summary>
        /// <param name="Argument">number</param>
        /// <param name="degree">quotient of number</param>
        /// <param name = "result">expected number in quotient</param>
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