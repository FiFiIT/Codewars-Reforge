using System.Linq;
using System;

namespace CSharp._5kyu
{
    public static partial class Kata5
    {
        public static string convertFrac(long[,] lst)
        {
            long m = 0;
            for (int i = 0; i < lst.Length; i++)
            { 
                m = lst[i, 1] > m ? lst[i, 1] : m;
            }

            Console.WriteLine(m);

            return String.Empty;
        }
    }
}