using System.Linq;
using System;

namespace CSharp._6Kyu
{
    public static partial class Kata6
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            var n = string.Join("", numbers);

            return String.Format("({0}) {1}-{2}", n.Substring(0, 3), n.Substring(3, 3), n.Substring(6));
        }

        public static string CreatePhoneNumber_2(int[] numbers)
        {
            return long.Parse(String.Concat(numbers)).ToString("(000) 000-0000");
        }
    }
}