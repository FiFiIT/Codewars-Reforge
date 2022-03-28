using System.Linq;
using System;

namespace CSharp._6Kyu
{
    public static partial class Kata6
    {
        public static int ipToInt32(string ip)
        {
            var result = string.Join("", ip.Split(".").Select(a => Convert.ToString(int.Parse(a), 2).PadLeft(8, '0')));

            return Convert.ToInt32(result, 2);
        }
    }
}

