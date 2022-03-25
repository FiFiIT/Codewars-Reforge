using System;
using System.Collections.Generic;
using CSharp._7Kyu;
namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 10, 343445353, 3453445, 2147483647 };
            var result = Kata7.sumTwoSmallestNumbers_2(tab);

            Console.WriteLine(result);
        }
    }
}
