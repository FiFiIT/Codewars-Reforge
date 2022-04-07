using System.Linq;
using System;

namespace CSharp._6Kyu
{
    public static partial class Kata6
    {
        public static int DigitalRoot(long n)
        {
            int number = n.ToString().ToArray().Sum(x => int.Parse(x.ToString()));

            if (number > 9)
            {
                number = DigitalRoot(number);
            }

            return number;
        }

        public static int DigitalRoot_Kata(long n)
        {
            return (int)(1 + (n - 1) % 9);
        }
    }
}
