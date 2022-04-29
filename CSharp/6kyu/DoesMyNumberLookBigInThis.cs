using System.Linq;
using System;
using System.Collections.Generic;

namespace CSharp._6Kyu
{
    public static partial class Kata6
    {
        public static bool Narcissistic(int value)
        {
            var result = value.ToString().Select(v => Math.Pow(int.Parse(v.ToString()), value.ToString().Length));


            return result.Sum() == value;
        }
    }
}