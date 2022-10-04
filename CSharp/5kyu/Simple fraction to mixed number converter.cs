using System;
using System.Linq;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static string MixedFraction(string s)
        {
            var fractions = s.Split("/").Select(int.Parse).ToList();
            var x = fractions[0];
            var y = fractions[1];

            if (y == 0) throw new DivideByZeroException("Pamiętaj cholero nie dziel przez zero");

            var sign = "";

            if ((double)x / y < 0) sign = "-";

            x = Math.Abs(x);
            y = Math.Abs(y);

            var a = x / y;
            var r = x % y;

            if (r == 0) return $"{sign}{a}";

            var d = GCD2(x, y);

            return a == 0 ? $"{sign}{r / d}/{y / d}" : $"{sign}{a} {r / d}/{y / d}";
        }

        private static int GCD2(int a, int b) => b == 0 ? a : GCD2(b, a % b);
    }
}