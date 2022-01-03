using System.Linq;
using System;

namespace CSharp._7Kyu
{
    public static partial class Kata7
    {
        public static int SquareDigits(int n)
        {
            var result = string.Join("", n.ToString().Select(i => (int)Math.Pow(char.GetNumericValue(i), 2)));

            return int.Parse(result);
        }
    }
}