using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp._5kyu
{
    public partial class Kata5
    {
        public static long[] Smallest(long n)
        {
            var data = new long[] { n, 0, 0 };
            var str = n.ToString();
            for (int i = 0; i < str.Length; i++)
            {
                string d = str.Substring(i, 1);
                var s = str.Remove(i, 1);
                for (int j = 0; j < str.Length; j++)
                {
                    var nn = long.Parse(s.Insert(j, d));
                    if (nn < data[0])
                    {
                        data[0] = nn;
                        data[1] = i;
                        data[2] = j;
                    }
                }
            }

            return data;
        }
    }
}