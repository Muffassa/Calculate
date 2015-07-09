using System;
using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    class TwoArgumetFactoryTests
    {
        /// <summary>
        /// Function of testing factory for two arguments
        /// </summary>
        /// <param name="expectedTypeOfOperation">expected type of operation</param>
        /// <param name="nameOfOperation">name of operation whitch type we will equalize expected type</param>
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
