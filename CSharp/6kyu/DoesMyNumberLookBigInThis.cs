using System.Linq;
using System;
using System.Collections.Generic;

namespace CSharp._6Kyu
{
    public static partial class Kata6
    {
        public static bool Narcissistic(int value)
        {
            string strValue = value.ToString();
            int pow = strValue.Length;

            var result = strValue.Select(v => Math.Pow(v.CharToInt(), pow));

            return result.Sum() == value;
        }

        public static int CharToInt(this char c)
        {
            int result;
            if (!int.TryParse(c.ToString(), out result))
            {
                throw new ArgumentException($"Couldn't parse value '{c}' to int");
            }

            return result;
        }
    }
}