using System;
namespace CSharp._7Kyu
{
    public static partial class Kata7
    {
        public static long FindNextSquare(long num)
        {
            var result = Math.Sqrt(num);
            long r = -1;
            if (result % 1 == 0)
            {
                r = (long)Math.Pow(result + 1, 2);
            }

            return r;
        }
    }
}