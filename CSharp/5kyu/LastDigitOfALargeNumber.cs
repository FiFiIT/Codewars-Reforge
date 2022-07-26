using System.Linq;
using System;
using System.Numerics;
using System.Collections.Generic;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static int GetLastDigit(BigInteger n1, BigInteger n2)
        {
            if (n2 == 0) return 0;

            int pow = (int)(n2 % 4);
            int n = (int)(n1 % 10);

            if (pow == 0) pow = 4;

            var result = (int)Math.Pow(n, pow);
            return result % 10;
        }
    }
}