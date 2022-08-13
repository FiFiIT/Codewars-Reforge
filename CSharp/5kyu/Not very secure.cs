using System;
using System.Text.RegularExpressions;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static bool Alphanumeric_fifi(string str)
        {
            var valid = Regex.Match(str, @"^[a-z0-9]+$", RegexOptions.IgnoreCase).Success;
            var whitespace = Regex.Match(str, @"\s+").Success == false;

            return valid && whitespace;
        }
        public static bool Alphanumeric(string str) => new Regex("^[a-z0-9]+$", RegexOptions.IgnoreCase).Match(str).Success;
    }
}