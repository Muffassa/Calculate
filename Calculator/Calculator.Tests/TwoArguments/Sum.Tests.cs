using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    
    [TestFixture]
    class SumTests
    {
        [Test]
        public void Calculate()
        {
            var calculator = new Sum();
            var testResult = calculator.Calculate(5,5);
            Assert.AreEqual(10,testResult);
        }
    }
}

