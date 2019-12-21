using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmPractice;

namespace AlgorithmUnitTests
{
    [TestClass]
    public class HexToIntUnitTests
    {
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

        [TestMethod]
        public void GetHexForTen()
        {
            Assert.AreEqual("0A-00-00-00", HexOp.GetHexForInt(10));
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

        //NOTE: C#'s BitConverter library is little endian, even on x86 
        //(as shown by the Unit Test below) 
        //This is why the hex values above seem backwards.
        [TestMethod]
        public void IsLittleEndian()
        {
            Assert.AreEqual(true, HexOp.IsLittleEndian());
        }
    }
}
