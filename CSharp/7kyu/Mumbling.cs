using System;
using System.Linq;
using System.Text;

namespace CSharp._7Kyu
{
    public static partial class Kata7
    {
        public static string Mumbling(string text)
        {
            return string.Join("-", text.ToLower().Select((c, i) => char.ToUpper(c) + new String(c, i)));
        }

        public static string Mumbling2(string text)
        {
            if (text.Length < 1) return "";

            var sb = new StringBuilder();
            int count = 0;
            foreach (char c in text.ToLower())
            {
                sb.Append(Char.ToUpper(c))
                    .Append(new String(c, count++))
                    .Append("-");
            }

            return sb.ToString().TrimEnd('-');
        }
    }
}