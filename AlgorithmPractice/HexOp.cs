using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    //NOTE: Hex value is not a datatype in C or C# (although bytes are).
    //The computer converts passed hex values to binary representations of ints
    public class HexOp
    {
        public static int GetIntForHex(int a)
        {
            return a;
        }

        public static String GetHexForInt(int a)
        {
            var bytes = BitConverter.GetBytes(a);
            return BitConverter.ToString(bytes);
        }

        public static Boolean IsLittleEndian()
        {
            return BitConverter.IsLittleEndian;
        }

    }
}
