using System.Linq;
using System;

namespace CSharp._6Kyu
{
    public static partial class Kata6
    {
        public static int Persistence_kata(long n)
        {
            int loops = 0;
            while (n > 9)
            {
                n = n.ToString().Select(digit => int.Parse(digit.ToString())).Aggregate((a, b) => a * b);
                loops++;
            }
            return loops;
        }
        public static int Persistence(long n)
        {
            int loops = 0;

            while (n > 9)
            {
                n = Multiply(n);
                loops++;
            }

            return loops;
        }

        private static long Multiply(long number)
        {
            long result = 1;

            while (number > 0)
            {
                result = result * (number % 10);
                number = number / 10;
            }

            return result;
        }
    }
}