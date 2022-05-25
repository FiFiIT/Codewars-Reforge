using System.Linq;
using System;
using System.Text.RegularExpressions;

namespace CSharp._6Kyu
{
    public static partial class Kata6
    {
        public static string ToCamelCase_Kata(string str)
        {
            // match.Groups[0] is always the same as match.Value, which is the entire match.
            // match.Groups[1] is the first capturing group in your regular expression.
            return Regex.Replace(str, @"[-_](\w)", m => m.Groups[1].Value.ToUpper());
        }
        public static string ToCamelCase(string str)
        {
            return String.Join("", str.Split(new char[] { '_', '-' }).Select((w, i) => i > 0 ? w[0].ToString().ToUpper() + w.Substring(1) : w));
        }
    }
}