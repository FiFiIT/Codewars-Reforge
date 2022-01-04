using System;
namespace CSharp._7Kyu
{
    public static partial class Kata7
    {
        public static string GetTheMiddleCharacter(string text)
        {
            if (text.Length <= 1) return text;

            var middle = (int)Math.Floor((decimal)text.Length / 2);
            var odd = text.Length % 2;
            return text.Substring(middle - 1 + odd, 2 - odd);
        }

        public static string GetTheMiddleCharacter2(string text)
        {
            return string.IsNullOrEmpty(text)
                ? text
                : text.Substring((text.Length - 1) / 2, 2 - text.Length % 2);
        }
    }
}