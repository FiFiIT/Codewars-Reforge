using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static string GenerateHashtag(string str)
        {
            var result = String.Join("", str.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(w => w.TitleCase()));

            return result.Length > 140 || result.Length == 0 ? "false" : "#" + result;
        }

        public static string TitleCase(this string word)
        {
            return word[0].ToString().ToUpper() + word.Substring(1).ToLower();
        }

        public static string ToTitleCase(this string word)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(word);
        }
    }
}