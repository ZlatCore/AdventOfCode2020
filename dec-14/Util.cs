using System;
using System.Collections.Generic;
using System.Text;

namespace dec_14
{
    class Util
    {

        public static string ToBinaryString(long input)
        {
            return Convert.ToString(input, 2).PadLeft(36, '0');
        }

        public static long FromBinaryString(string input)
        {
            return Convert.ToInt64(input, 2);
        }

        public static long FromCharArray(char[] input)
        {
            return FromBinaryString(new string(input));
        }
    }
}
