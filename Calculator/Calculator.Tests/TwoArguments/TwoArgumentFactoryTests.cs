using System;
using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    class TwoArgumetFactoryTests
    {
        [TestCase(typeof(Sum), "Sum")]
        [TestCase(typeof(Subtraction), "Subtraction")]
        [TestCase(typeof(Division), "Division")]
        [TestCase(typeof(Multiplication), "Multiplication")]
        [TestCase(typeof(Pow), "Pow")]
        public void CreateCalculator(Type expectedTypeOfOperation, string nameOfOperation)
        {
            Type resultType = TwoArgumentFactory.CreateCalculator(nameOfOperation).GetType();
            Assert.AreEqual(expectedTypeOfOperation, resultType);
        }
    }
}
