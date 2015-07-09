using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    class SubtractionTests
    {
        /// <summary>
        /// Test function for computation differenc of two arguments
        /// </summary>
        /// <param name="firstArgument">argument whereof takeing</param>
        /// <param name="secondArgument">argument which taking</param>
        /// <param name="result">expected result</param>
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
