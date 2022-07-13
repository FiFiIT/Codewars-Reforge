using System.Linq;
using System;
using System.Text.RegularExpressions;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static bool validate(string password)
        {
            var alphanumericAtLeastSixLong = Regex.Match(password, @"^[a-zA-Z0-9_]{6,}$");
            var upperCaseLetters = Regex.Match(password, @".*[A-Z]");
            var lowerCaseLetters = Regex.Match(password, @".*[a-z]");
            var haveNumber = Regex.Match(password, @".*\d");

            return alphanumericAtLeastSixLong.Success == true && upperCaseLetters.Success == true && lowerCaseLetters.Success == true && haveNumber.Success == true;
        }
    }
}