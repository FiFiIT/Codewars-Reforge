using System.Linq;
using System;
using System.Collections.Generic;

namespace CSharp._7Kyu
{
    public static partial class Kata7
    {
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            return data.Select(d => d[0] >= 55 && d[1] > 7 ? "Senior" : "Open");
        }
    }
}