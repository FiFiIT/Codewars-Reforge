using System;

namespace CSharp._7Kyu
{
    public static partial class Kata7
    {
        public static bool IsSquare(int n)
        {
            return Math.Ceiling(Math.Sqrt(n)) == Math.Floor(Math.Sqrt(n));
        }

        public static bool IsSquare2(int n)
        {
            return Math.Sqrt(n) % 1 == 0;
        }
    }
}