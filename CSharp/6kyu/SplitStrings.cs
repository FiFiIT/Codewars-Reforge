using System.Linq;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CSharp._6Kyu
{
    public static partial class Kata6
    {
        public static string[] SplitString(string str)
        {
            if (str.Length % 2 == 1)
            {
                str += "_";

            }

            int r = (int)(str.Length / 2 + 0.5);
            // int v = (int)Math.Round(r, MidpointRounding.AwayFromZero);

            return Enumerable.Range(0, r)
                .Select(i => str.Substring(i * 2, 2)).ToArray();
        }

        public static string[] SplitString_kata_1(string str)
        {
            if (str.Length % 2 == 1)
            {
                str += "_";
            }

            List<string> list = new List<string>();
            for (int i = 0; i < str.Length; i += 2)
            {
                list.Add(str[i].ToString() + str[i + 1]);
            }

            return list.ToArray();
        }
        public static string[] SplitString_kata_2(string str)
        {
            if (str.Length % 2 == 1)
            {
                str += "_";
            }

            return Enumerable.Range(0, str.Length)
                .Where(x => x % 2 == 0)
                .Select(x => str.Substring(x, 2)).ToArray();
        }
        public static string[] SplitString_kata_3(string str)
        {
            return Regex.Matches(str + "_", @"\w{2}").Select(x => x.Value).ToArray();
        }
    }
}