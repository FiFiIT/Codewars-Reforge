using System;
using System.Linq;

namespace CSharp._7Kyu
{
    public static partial class Kata7
    {
        public static int FindShort(string s)
        {
            return s.Split(" ").Min(w => w.Length);
        }
    }
}
