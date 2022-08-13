<<<<<<< HEAD
using System.Linq;
using System;
=======
using System;
using System.Collections.Generic;
using System.Linq;
>>>>>>> b23814ee9f7e4162ac2e66256d1d713720c938d0

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
<<<<<<< HEAD

        public static (int, int)? IsPerfectPower(int n)
        {
            if (n < 4) return null;
            int max = (int)Math.Log(n);
            int min = (int)Math.Sqrt(n);

            for (int i = 2; i <= min; i++)
            {
                var r = (n / i) % 1 == 0;
                for (int p = 2; p <= min; p++)
                {
                    var result = Math.Pow(i, p);
                    Console.WriteLine($"{i}**{p} = {result}");
                    if (result == n)
                    {
                        return (i, p);
                    }
                }

            }
=======
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

>>>>>>> b23814ee9f7e4162ac2e66256d1d713720c938d0
            return null;
        }
    }
}