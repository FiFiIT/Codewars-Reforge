using System.Linq;
using System;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharp._6Kyu
{
    public static partial class Kata6
    {
        public static string AlphabetPosition(string text)
        {
            // Console.WriteLine(Convert.ToByte('a'));
            //text = text.ToLower().Replace(" ", "");
            text = Regex.Replace(text.ToLower(), @"[^a-z]", "");

            return string.Join(" ", Encoding.ASCII.GetBytes(text).Select(b => b - 96));
        }

        public static string AlphabetPosition_kata(string text)
        {
            return string.Join(" ", text.ToLower().Where(t => char.IsLetter(t)).Select(c => c - 'a' + 1));
        }

        public static string AlphabetPosition_kata2(string text)
        {
            return string.Join(" ", text.ToLower().Where(c => char.IsLetter(c)).Select(a => a & 31));
        }
    }
}