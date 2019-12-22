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
        public void GetBitsForBigNumber()
        {
            Assert.AreEqual("00001010000010110000110000001101", BitOp.GetBits(168496141, 32));
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

    [TestClass]
    public class AddUnitTests
    {
        [TestMethod]
        public void AddTwoPositivies()
        {
            Assert.AreEqual(14, BitOp.Add(2, 12));
        }
        [TestMethod]
        public void AddLeftNegRightPos()
        {
            Assert.AreEqual(9, BitOp.Add(-3, 12));
        }
        [TestMethod]
        public void AddRightPosLeftNeg()
        {
            Assert.AreEqual(-4, BitOp.Add(4, -8));
        }
        [TestMethod]
        public void AddTwoNegatives()
        {
            Assert.AreEqual(-16, BitOp.Add(-9, -7));
        }
    }

    [TestClass]
    public class SubtractUnitTests
    {
        [TestMethod]
        public void SubtractTwoPositives()
        {
            Assert.AreEqual(-9, BitOp.Subtract(2, 11));
        }
        [TestMethod]
        public void SubtractNegLeftPositiveRight()
        {
            Assert.AreEqual(-13, BitOp.Subtract(-5, 8));
        }
        [TestMethod]
        public void SubtractPositiveLeftNegativeRight()
        {
            Assert.AreEqual(8, BitOp.Subtract(7, -1));
        }
    }
    [TestClass]
    public class MultiplyUnitTests
    {
        [TestMethod]
        public void MultiplyPositives()
        {
            Assert.AreEqual(32, BitOp.Multiply(4, 8));
        }
        [TestMethod]
        public void MultiplyNegatives()
        {
            Assert.AreEqual(15, BitOp.Multiply(-5, -3));
        }
        [TestMethod]
        public void MultiplyNegativeAndAPositive()
        {
            Assert.AreEqual(-7, BitOp.Multiply(7, -1));
        }
    }

    [TestClass]
    public class DivideUnitTests
    {
        [TestMethod]
        public void DividePositives()
        {
            Assert.AreEqual(4, BitOp.Divide(8, 2));
        }
        [TestMethod]
        public void DivideNegatives()
        {
            Assert.AreEqual(5, BitOp.Divide(-15, -3));
        }
        [TestMethod]
        public void DivideNegativeAndAPositive()
        {
            Assert.AreEqual(-7, BitOp.Divide(7, -1));
        }
        [TestMethod]
        public void DivideHasRemainder()
        {
            Assert.AreEqual(3, BitOp.Divide(15, 4));
        }
    }

}
