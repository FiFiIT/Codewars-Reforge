using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static string UInt32ToIP(uint ip)
        {
            return String.Join(".", (new int[] { 24, 16, 8, 0 }).Select(e => ip >> e & 255));
        }
        public static string UInt32ToIP_fifi(uint ip)
        {
            var address = new List<int>();
            var binary = Convert.ToString(ip, 2).PadLeft(32, '0');


            for (int i = 0; i < 4; i++)
            {
                var n = binary.Substring(8 * i, 8);
                address.Add(Convert.ToInt32(n, 2));
            }

            return string.Join(".", address);
        }
    }
}