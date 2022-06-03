using System.Linq;
using System;
using System.Text.RegularExpressions;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static string Rot13(string message)
        {
            var result = message.ToCharArray().Select(c => c.Caeser());
            return String.Join("", result);
        }

        public static char Caeser(this char c)
        {
            if (!Char.IsLetter(c)) return c;

            int step = 65;

            if (c > 90) step = 97;

            c = c.ToString()[0];
            var result = (c - step + 13) % 26;

            return (char)(result + step);
        }

        public static bool IsApha(this char c) => Regex.IsMatch(c.ToString(), "[a-zA-Z]");
    }
};