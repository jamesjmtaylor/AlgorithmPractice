using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmPractice;

namespace AlgorithmUnitTests
{
    [TestClass]
    public class GetBitUnitTests
    {
        [TestMethod]
        public void GetBitForThreeAtPositionZero()
        {
            Assert.AreEqual(true, BitOp.GetBitAt(0, 3)); // 011, bit 0 is true
        }
        [TestMethod]
        public void GetBitForThreeAtPositionOne()
        {
            Assert.AreEqual(true, BitOp.GetBitAt(1, 3)); // 011, bit 1 is true
        }
        [TestMethod]
        public void GetBitForThreeAtPositionTwo()
        {
            Assert.AreEqual(false, BitOp.GetBitAt(2, 3)); // 011, bit 2 is false
        }
        [TestMethod]
        public void GetBitForThreeAtPositionThree()
        {
            Assert.AreEqual(false, BitOp.GetBitAt(3, 3)); // 011, bit 3 is false
        }
        [TestMethod]
        public void GetBitForNegThreeAtPositionOne()
        {
            Assert.AreEqual(false, BitOp.GetBitAt(1, -3)); // ...100, bit 1 is false
        }
        [TestMethod]
        public void GetBitForNegThreeAtPositionThree()
        {
            Assert.AreEqual(true, BitOp.GetBitAt(2, -3)); // ...100, bit 2 is false
        }
    }

    [TestClass]
    public class GetBitsUnitTests
    {
        [TestMethod]
        public void GetBitsForThree()
        {
            Assert.AreEqual("0011", BitOp.GetBits(3,4));
        }
        [TestMethod]
        public void GetBitsForEleven()
        {
            Assert.AreEqual("01011", BitOp.GetBits(11, 5));
        }
        [TestMethod]
        public void GetBitsForFifteen()
        {
            Assert.AreEqual("01111", BitOp.GetBits(15,5));
        }
        [TestMethod]
        public void GetBitsForNegFive()
        {
            Assert.AreEqual("11010", BitOp.GetBits(-5, 5));
        }
        [TestMethod]
        public void GetBitsForNegEleven()
        {
            Assert.AreEqual("10100", BitOp.GetBits(-11, 5));
        }
    }
}
