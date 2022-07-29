using System.Linq;
using System;
using System.Numerics;
using System.Collections.Generic;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static BigInteger MemoizedFibonacci(BigInteger n)
        {
            var cashe = new Dictionary<BigInteger, BigInteger>();

            BigInteger Traverse(BigInteger n)
            {
                if (cashe.ContainsKey(n)) return cashe[n];
                if (n == 0 || n == 1) return n;

                var result = Traverse(n - 1) + Traverse(n - 2);
                cashe[n] = result;

                return result;
            }

            return Traverse(n);
        }
    }
}