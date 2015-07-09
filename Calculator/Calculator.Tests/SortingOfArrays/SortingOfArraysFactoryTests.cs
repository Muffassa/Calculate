using System;
using Calculator.SortingOfArrays;
using NUnit.Framework;

namespace CalculatorTests.SortingOfArrays
{
    [TestFixture]
    class SortingOfArraysTests
    {
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
