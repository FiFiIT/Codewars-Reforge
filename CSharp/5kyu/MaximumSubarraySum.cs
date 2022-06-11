using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static int MaxSequence(int[] arr)
        {
            int max = 0, res = 0, sum = 0;

            foreach (int item in arr)
            {
                sum += item;
                max = sum > max ? max : sum;
                res = res > sum - max ? res : sum - max;
            }

            return res;
        }
        public static int MaxSequence_kata_2(int[] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    sum += arr[j];
                    max = Math.Max(sum, max);
                }
            }

            return max;
        }
    }
}