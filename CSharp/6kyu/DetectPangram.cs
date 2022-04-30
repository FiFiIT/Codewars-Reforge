using System.Linq;
using System;

namespace CSharp._6Kyu
{
    public static partial class Kata6
    {
        public static bool IsPangram(string str)
        {
            return "abcdefghijklmnopqrstuvwxyz".Where(a => str.ToLower().IndexOf(a) == -1).Count() == 0;
        }

        public static bool IsPangram_Kata_1(string str)
        {
            return str.ToLower().Where(c => Char.IsLetter(c)).Distinct().Count() == 26;
        }
    }
}

