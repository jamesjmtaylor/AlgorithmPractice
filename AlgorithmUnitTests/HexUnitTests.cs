using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmPractice;

namespace AlgorithmUnitTests
{
    [TestClass]
    public class HexToIntUnitTests
    {

        //NOTE: C#'s Ints are stored as Big Endian (biggest value first)
        [TestMethod]
        public void GetIntForLargeHex()
        {
            Assert.AreEqual(168496141, HexOp.GetIntForHex(0x0A0B0C0D));
        }

        [TestMethod]
        public void GetIntForZeroHex()
        {
            Assert.AreEqual(0, HexOp.GetIntForHex(0x00000000)); 
        }
 
        [TestMethod]
        public void GetIntForTenHex()
        {
            Assert.AreEqual(10, HexOp.GetIntForHex(0x0000000A));
        }

        //NOTE: C#'s BitConverter library is little endian, even on x86 
        //(as shown by the Unit Test below) 
        //This is why the hex values above seem backwards.
        [TestMethod]
        public void GetHexForTen()
        {
            Assert.AreEqual("0A-00-00-00", HexOp.GetHexForInt(10));
        }
        [TestMethod]
        public void GetHexForLargeInt()
        {
            Assert.AreEqual("0D-0C-0B-0A", HexOp.GetHexForInt(168496141));
        }
        [TestMethod]
        public void GetHexForTwoFiftyFive()
        {
            Assert.AreEqual("FF-00-00-00", HexOp.GetHexForInt(255));
        }
        [TestMethod]
        public void GetHexForNegativeValue()
        {
            Assert.AreEqual("D1-FF-FF-FF", HexOp.GetHexForInt(-47));
        }

    
        [TestMethod]
        public void IsLittleEndian()
        {
            Assert.AreEqual(true, HexOp.IsLittleEndian());
        }
    }
}
