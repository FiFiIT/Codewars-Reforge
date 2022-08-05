using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static long IpsBetween(string start, string end)
        {
            return IpValue(end) - IpValue(start);
        }

        public static long IpValue(string ip)
        {
            var result = ip.Split(".").Select((b, i) => Convert.ToInt64(b) << 24 - (8 * i));
            return result.Sum();
        }
    }
}