using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    public class BitOp
    {
        public static int Add(int a, int b)
        {
            while (b != 0)
            {
                int carry = a & b;
                a = a ^ b;
                b = carry << 1;
            }
            return a;
        }

        public static Boolean GetBitAt(int pos, int num)
        {
            if (num < 0)
            { //Compensate for two's compliment
                num = Add(num, -1);
            }
            return ((num & (1 << pos)) != 0);
        }

        public static String GetBits(int num, int length = 32)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 31; i >= 0; i--)
            {
                sb.Append(GetBitAt(i, num) ? "1" : "0");
            }
            sb.Remove(0,32-length);
            return sb.ToString();
        }

        //Uses NOT operator to get two's complement. The best way to think of two's complement is prepending a 1 to the binary value makes it negative. 
        //The magnitude of the countdown works in reverse, so for a 4 bit two complement 1111 equals -1, 1110 equals -2 and so on.
        public static int Negate(int a)
        {
            return Add(~a, 1);
        }

        public static int Absolute(int a)
        {
            return (a > 0) ? a : Negate(a);
        }

        public static int Subtract(int a, int b)
        {
            return Add(a,Negate(b));
        }

        public static int Multiply(int a, int b)
        {
            bool negativeMultiplication = a < 0;
            int iterations = Absolute(a);
            int sum = 0;
            for (int i = 0; i < iterations; i = Add(i,1))
            {
                sum = (negativeMultiplication) ? Subtract(sum,b) : Add(sum, b);
            }
            return sum;
        }

        public static int Divide(int a, int b)
        {
            return a;
        }
    }
}
