using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test2.PascalsTriangle;

namespace Test2.UnitTests
{
    [TestClass]
    public class BlaiseTests
    {
        Blaise b;

        private void Setup(int numberOfRows)
        {
            b = new Blaise(numberOfRows);
        }

        [TestMethod]
        public void EvaluateColumn0Row2_Success()
        {
            Setup(2);

            int result = b.Pascal(0, 2);
            int expected = 1;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EvaluateColumn0Row2_Fail()
        {
            Setup(2);

            int result = b.Pascal(0, 2);
            int notExpected = 12;

            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod]
        public void EvaluateColumn1Row2_Success()
        {
            Setup(2);

            int result = b.Pascal(1, 2);
            int expected = 2;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EvaluateColumn1Row2_Fail()
        {
            Setup(2);

            int result = b.Pascal(1, 2);
            int notExpected = 12;

            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod]
        public void EvaluateColumn1Row3_Success()
        {
            Setup(3);

            int result = b.Pascal(1, 3);
            int expected = 2;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EvaluateColumn1Row3_Fail()
        {
            Setup(3);

            int result = b.Pascal(1, 3);
            int notExpected = 100;

            Assert.AreNotEqual(notExpected, result);
        }

        #region Process Tests

        [TestMethod]
        public void Process_Success()
        {
            Setup(3);

            b.Process();

            Assert.IsTrue(true);
        }

        #endregion
    }
}
