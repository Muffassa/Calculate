using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    class SinTests
    {
        /// <summary>
        /// Test for method sin for one argument
        /// </summary>
        /// <param name="argument">argument which we will calculate</param>
        /// <param name="result">expected result of operation "sin"</param>
        [TestCase(0, 0)]
        public void Calculate(double argument, double result)
        {
            
            var calculator = new Sin();
            var testResult = calculator.Calculate(argument);
            Assert.AreEqual(result, testResult);
        }
    }
}
