using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp._5kyu
{
    public partial class Kata5
    {
        private const string _CharList = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static string dec2FactString(long nb)
        {
            // 463 ÷ 1 = 463, remainder 0
            // 463 ÷ 2 = 231, remainder 1
            // 231 ÷ 3 = 77, remainder 0
            // 77 ÷ 4 = 19, remainder 1
            // 19 ÷ 5 = 3, remainder 4
            // 3 ÷ 6 = 0, remainder 3

            var result = new StringBuilder("0");
            int i = 2;
            while (nb > 0)
            {
                result.Insert(0, _CharList[(int)(nb % i)]);
                nb /= i++;
            }

            return result.ToString();
        }
        public static long factString2Dec(string str)
        {
            long result = 0;

            if (String.IsNullOrEmpty(str))
                return result;

            // "341010" 
            // = 3×5! + 4×4! + 1×3! + 0×2! + 1×1! + 0×0!
            // = ((((3×5 + 4)×4 + 1)×3 + 0)×2 + 1)×1 + 0
            // = 463

            for (int i = 0; i < str.Length; i++)
            {
                result += (long)_CharList.IndexOf(str[i]);
                long factorial = str.Length - i - 1;
                if (factorial > 0)
                {
                    result *= factorial;
                }

            }

            return result;
        }
    }
}