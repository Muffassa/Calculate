using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    class OneArgumetFactoryTests
    {
        /// <summary>
        /// Function of testing factory for one argument
        /// </summary>
        /// <param name="expectedTypeOfOperation">expected type of operation</param>
        /// <param name="nameOfOperation">name of operation whitch type we will equalize expected type </param>
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
