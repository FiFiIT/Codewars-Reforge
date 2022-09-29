using System.Linq;
using System;
using System.Text.RegularExpressions;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static string ToUnderscore(int str)
        {
            return str.ToString();
        }

        public static string ToUnderscore(string str)
        {
            return Regex.Replace(str, @"\B([A-Z])\B", "_$1").ToLower();
        }
    }
}