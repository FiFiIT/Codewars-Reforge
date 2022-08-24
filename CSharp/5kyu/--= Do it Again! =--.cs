using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static int JosSurvivor2(int n, int k)
        {
            k -= 1;
            var survivours = Enumerable.Range(1, n).ToList();
            int pointer = k % survivours.Count();

            for (int i = 0; i < n - 1; i++)
            {
                survivours.RemoveAt(pointer);
                pointer = (pointer + k) % survivours.Count();
            }

            return survivours[0];
        }
        public static int JosSurvivor_kata_1(int n, int k)
        {
            int i = 1;
            for (int j = 1; j <= n; j++)
            {
                i = (i + k) % j;
            }

            return i + 1;
        }

        public static int JosSurvivor_kata_2(int n, int k)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return (JosSurvivor_kata_2(n - 1, k) + k - 1) % n + 1;
            }
        }
    }
}