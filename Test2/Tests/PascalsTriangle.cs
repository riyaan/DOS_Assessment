using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test2.PascalsTriangle;

namespace Test2.UnitTests
{
    [TestClass]
    public class PascalsTriangle
    {
        Blaise b;

        private void Setup()
        {
            b = new Blaise(5);
            //
        }

        [TestMethod]
        public void PascalEvaluate2Rows_Success()
        {
            Setup();

            int result = b.Pascal(0, 2);
            int expected = 1;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void PascalEvaluate2Rows_Fail()
        {
            Setup();

            int result = b.Pascal(0, 2);
            int notExpected = 12;

            Assert.AreNotEqual(notExpected, result);
        }
    }
}
