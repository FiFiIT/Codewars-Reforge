using System.Linq;
using System;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static string IncrementString(string s)
        {
            var number = s.GetNumber();

            var len = number.Length;
            if (len == 0)
            {
                number = "0";
                len = 1;
            }

            string format = new String('0', number.Length);

            var result = (int.Parse(number) + 1).ToString($"{format}");

            return s.GetNumber(false) + result;
        }

        public static string GetNumber(this string s, bool yes = true)
        {
            return String.Concat(s.ToCharArray().Where(c => !Char.IsLetter(c) == yes));
        }
    }
}