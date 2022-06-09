using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static int MaxSequence(int[] arr)
        {
            int sum = 0;
            int tmpSum = 0;
            int endIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                endIndex = arr.Length;
                while (endIndex > i)
                {
                    tmpSum = arr.Where((v, idx) => idx >= i && idx < endIndex).Sum();
                    if (tmpSum > sum)
                    {
                        sum = tmpSum;
                    }

                    endIndex--;
                }

            }

            return sum;
        }
    }
}