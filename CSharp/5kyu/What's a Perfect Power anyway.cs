using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static (int, int)? IsPerfectPower(int n)
        {
            int border = (int)Math.Sqrt(n);

            for (int i = 2; i <= border; border--)
            {
                int deg = Convert.ToInt32(Math.Log(n, border));
                if (Math.Pow(border, deg) == n)
                {
                    return (border, n);
                }
            }

            return null;
        }
    }
}