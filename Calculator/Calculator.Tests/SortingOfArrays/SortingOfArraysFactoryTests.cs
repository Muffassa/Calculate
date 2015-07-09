using System;
using Calculator.SortingOfArrays;
using NUnit.Framework;

namespace Calculator.Tests.SortingOfArrays
{
    [TestFixture]
    class SortingOfArraysTests
    {
        /// <summary>
        /// Test of Factoru for arrays 
        /// </summary>
        /// <param name="expectedTypeOfOperation">expected type of operation</param>
        /// <param name="nameOfOperation">name of operation whitch type we will equalize expected type </param>
        [TestCase(typeof(HeapSort), "HeapSort")]
        [TestCase(typeof(BubbleSort), "BubbleSort")]
        [TestCase(typeof(GnomeSort), "GnomeSort")]
        [TestCase(typeof(InsertionSort), "InsertionSort")]
        public void CreateSorting(Type expectedTypeOfOperation, string nameOfOperation)
        {
            Type resultType = SortingOfArraysFactory.CreateSorting(nameOfOperation).GetType();
            Assert.AreEqual(expectedTypeOfOperation, resultType);
        }
    }
}
