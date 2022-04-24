using System.Linq;
using System;

namespace CSharp._6Kyu
{
    public static partial class Kata6
    {
        public static int FindEvenIndex(int[] arr)
        {
            int left = 0;
            int right = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                left = arr.Where((a, idx) => idx < i).Sum();
                right = arr.Where((a, idx) => idx > i).Sum();

                if (left == right)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int FindEvenIndex_Kata_1(int[] arr)
        {
            int left = 0, right = arr.Sum();

            for (int i = 0; i < arr.Length; i++)
            {
                right -= arr[i];

                if (left == right)
                {
                    return i;
                }

                left += arr[i];
            }

            return -1;
        }

        public static int FindEvenIndex_Kata_2(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr.Take(i).Sum() == arr.Skip(i + 1).Sum())
                {
                    return i;
                }
            }
            return -1;
        }
    }
}