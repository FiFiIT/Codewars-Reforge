using System.Linq;
using System;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {

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
            return null;
        }
    }
}