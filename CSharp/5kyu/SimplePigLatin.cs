using System.Text.RegularExpressions;
using System.Linq;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static string PigIt(string str)
        {
            return Regex.Replace(str, @"(\w)(\w*)(\s|$)", @"$2$1ay$3");
        }

        public static string PigIt_Kata(string str)
        {
            // char.IsPunctuation Indicates whether a Unicode character is categorized as a punctuation mark.
            return string.Join(" ", str.Split(" ").Select(w => w.Any(char.IsPunctuation) ? w : w.Substring(1) + w[0] + "ay"));
        }
    }
}