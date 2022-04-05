using System;
using System.Linq;

namespace CSharp._7Kyu
{
    public static partial class Kata7
    {
        public static string AddBinary(int a, int b)
        {
            return Convert.ToString(a + b, 2);
        }
    }
}