using System.Linq;
using System;
using System.Collections.Generic;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static int? chooseBestSum(int t, int k, List<int> ls)
        {
            var result = 0;
            for (int i = 0; i < k; i++)
            {
                result = ls[i] + ls[i + 1] + ls[i + 2];
            }

            return result;
        }
    }
}