using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    class CosTests
    {
        /// <summary>
        /// Test of method cos
        /// </summary>
        /// <param name="argument">argument of calculating</param>
        /// <param name="result">expecting cos of argument</param>
        [TestCase(0, 1)]
        public void Calculate(double argument, double result)
        {
            var calculator = new Cos();
            var testResult = calculator.Calculate(argument);
            Assert.AreEqual(result, testResult);
        }
    }
}
