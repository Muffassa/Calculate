using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTests.OneArgument
{
    [TestFixture]
    class OneArgumetFactoryTests
    {
        [TestCase(typeof(Absolute), "Abs")]
        [TestCase(typeof(Cos),"Cos")]
        [TestCase(typeof(Sin), "Sin")]
        [TestCase(typeof(Factorial), "Factorial")]
        [TestCase(typeof(Sqrt), "Sqrt")]
        public void CreateCalculator(Type expectedTypeOfOperation, string nameOfOperation )
        {
            Type resultType = OneArgumentFactory.CreateCalculator(nameOfOperation).GetType();
            Assert.AreEqual(expectedTypeOfOperation, resultType);
        }
    }
}
