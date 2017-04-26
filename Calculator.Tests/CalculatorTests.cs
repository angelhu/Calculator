using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_Should_Add_Two_Numbers_And_Return_The_Sum()
        {
            int result = Calculator.Add(10, 5);

            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Add_Should_Not_Handle_Negative_Numbers()
        {
            Assert.ThrowsException<ArgumentException>(() => Calculator.Add(-1, 10));
            Assert.ThrowsException<ArgumentException>(() => Calculator.Add(10, -1));
        }

        [TestMethod]
        public void Subtract_Should_Subtract()
        {
            int result = Calculator.Subtract(13, 5);

            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Multiply_Should_Multiply()
        {
            int result = Calculator.Multiply(5, 6);

            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void Division_Should_Divide()
        {
            int result = Calculator.Division(26, 2);

            Assert.AreEqual(13, result);
        }
    }
}
