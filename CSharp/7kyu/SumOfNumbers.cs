using System;

namespace CSharp._7Kyu
{
    public static partial class Kata7
    {
        public static int GetSum(int a, int b)
        {
            return (a + b) * (Math.Abs(a - b) + 1) / 2;
        }
    }
}