using System.Linq;
using System;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static string Rgb(int r, int g, int b)
        {
            return String.Format("{0:X2}{1:X2}{2:X2}", r.Rnd(), g.Rnd(), b.Rnd());
        }

        private static int Rnd(this int rgb)
        {
            return Math.Min(255, Math.Max(0, rgb));
        }
    }
}