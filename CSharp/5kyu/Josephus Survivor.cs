using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static int JosSurvivor(int n, int k)
        {
            var circle = Enumerable.Range(1, n).ToList();
            var pointer = k - 1;

            for (int i = 0; i < n - 1; i++)
            {
                circle.RemoveAt(pointer);
                pointer = (pointer + k - 1) % circle.Count;
            }

            return circle[0];
        }
    }
}