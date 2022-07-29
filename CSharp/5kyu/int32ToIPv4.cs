using System;
using System.Collections.Generic;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static string UInt32ToIP(uint ip)
        {
            var address = new List<int>();
            var binary = Convert.ToString(ip, 2).ToString("D32");


            for (int i = 0; i < 4; i++)
            {
                var n = binary.Substring(8 * i, 8);
                address.Add(Convert.ToInt32(n, 2));
            }

            return string.Join(".", address);
        }
    }
}